Param(
    [Parameter(Mandatory = $true)]
    [String]$resourceGroup,

    [Parameter(Mandatory = $true)]
    [String]$location = "westeurope", # https://azuretracks.com/2021/04/current-azure-region-names-reference/

    [Parameter(Mandatory = $true)]
    [String]$environment = "dev",

    [Parameter(Mandatory = $false)]
    [String]$version = "1.0.0",

    # [Parameter(Mandatory = $false)]
    # [object]$secretApiKeyValue = $null, # example secret

    [Parameter(Mandatory = $false)]
    [String]$bicepFile = "main.bicep",

    [Parameter(Mandatory = $true)]
    [String]$bicepParametersFile = "main.parameters.dev.json",

    [Parameter(Mandatory = $false)]
    [Switch]$dryRun
)

function Convert-ToDevOpsVariable {
    [CmdletBinding()]
    param (
        [Parameter(Mandatory = $false)]
        [string]
        $variablePrefix = "bicepOutput_",
        [Parameter(Mandatory = $true)]
        [object]$deploymentOutputs
    )
    $deploymentOutputs.psobject.properties | ForEach-Object {
        Write-Host "🪛 Converting to DevOps Variable: $($_.Name): $($_.Value.value)"
        $vsoAttribs = "task.setvariable variable=$($variablePrefix)$($_.Name);isOutput=true";
        $var = "##vso[$vsoAttribs]$($_.Value.value)"
        Write-Host $var
    }
}

function Join-Objects($source, $extend) {
    if ($source.GetType().Name -eq "PSCustomObject" -and $extend.GetType().Name -eq "PSCustomObject") {
        foreach ($Property in $source | Get-Member -type NoteProperty, Property) {
            if ($null -eq $extend.$($Property.Name)) {
                continue;
            }
            $source.$($Property.Name) = Join-Objects $source.$($Property.Name) $extend.$($Property.Name)
        }
    }
    else {
        $source = $extend;
    }
    return $source
}

function AddPropertyRecurse($source, $toExtend) {
    if ($source.GetType().Name -eq "PSCustomObject") {
        foreach ($Property in $source | Get-Member -type NoteProperty, Property) {
            if ($null -eq $toExtend.$($Property.Name)) {
                $toExtend | Add-Member -MemberType NoteProperty -Value $source.$($Property.Name) -Name $Property.Name `

            }
            else {
                $toExtend.$($Property.Name) = AddPropertyRecurse $source.$($Property.Name) $toExtend.$($Property.Name)
            }
        }
    }
    return $toExtend
}

function Merge-Json($source, $extend) {
    $merged = Join-Objects $source $extend
    $extended = AddPropertyRecurse $merged $extend
    return $extended
}

function Merge-ParameterFiles {
    [CmdletBinding()]
    param (
        [Parameter(Mandatory = $true)]
        [String]$sourceJsonFilename1,

        [Parameter(Mandatory = $true)]
        [String]$sourceJsonFilename2,

        [Parameter(Mandatory = $true)]
        [String]$outputFilename
    )

    $source1 = Get-Content -Path $sourceJsonFilename1 -Raw | ConvertFrom-Json
    $source2 = Get-Content -Path $sourceJsonFilename2 -Raw | ConvertFrom-Json

    $merged = Merge-Json $source1.parameters $source2.parameters

    $source1.parameters = $merged
    $source1 | ConvertTo-Json -Depth 100 | Out-File -FilePath .\$outputFilename
}

Write-Host "👀 Checking Bicep file..."
if ($false -eq (Test-Path $bicepFile)) {
    Write-Host "❌ The Bicep file $($bicepFile) cannot be found!" -ForegroundColor Red
    exit 1;
}

if ($false -eq (Test-Path $bicepParametersFile)) {
    Write-Host "❌ The Bicep Parameters file $($bicepParametersFile) cannot be found!" -ForegroundColor Red
    exit 1;
}

# NOTE: You must have logged in via 'az login' before running this deployment
Write-Host "👀 Checking if the Azure access token is valid..."
$azureAccessTokenExpiration = az account get-access-token --query "expiresOn" --output tsv
if ($DebugPreference -ne "SilentlyContinue") {
    Write-Host $azureAccessTokenExpiration -ForegroundColor Magenta
}

try {
    # expiry date example = 2021-08-18 14:13:30.365912
    $dt = [datetime]::ParseExact($azureAccessTokenExpiration, 'yyyy-MM-dd HH:mm:ss.ffffff', $null)
    Write-Host "✨ The Azure Access Token expires on: $($dt)" -ForegroundColor Cyan
}
catch {
    Write-Error "⚠️ Please login with az login"
    exit 1;
}

Write-Host "🔨 Creating Bicep parameters" -ForegroundColor Gray
$deploymentTimestamp = Get-Date -format "yyMMddHHmmss" -AsUTC

$parameters = New-Object PSObject -Property @{
    '$schema'      = 'https://schema.management.azure.com/schemas/2019-04-01/deploymentParameters.json#'
    contentVersion = "1.0.0.0"
    parameters     = @{
        environment    = @{ value = $environment }
        version        = @{ value = $version }
        deploymentDate = @{ value = $deploymentTimestamp }
    }
}

# if ($false -eq [string]::IsNullOrEmpty($secretApiKeyValue)) {
#     $parameters.parameters.Add("secretApiKey", @{ value = $secretApiKeyValue })
# }

$tempParametersFile = "parameters.tmp.json"
if (Test-Path $tempParametersFile) {
    Remove-Item $tempParametersFile
}

$parameters | ConvertTo-Json -Depth 100 | Out-File $tempParametersFile

Write-Host "🔨 Merging all parameters files" -ForegroundColor Gray
Merge-ParameterFiles -sourceJsonFilename1 $tempParametersFile `
    -sourceJsonFilename2 $bicepParametersFile `
    -outputFilename $tempParametersFile

$rgExists = az group exists -n $resourceGroup
if ($rgExists -eq $false) {
    Write-Host "🔨 Creating Resource Group $($resourceGroup)" -ForegroundColor Yellow
    $result = az group create -l $location -n $resourceGroup
    if (!$?) {
        Write-Host "❌ Could not create Resource Group $($resourceGroup)" -ForegroundColor Red
        Write-Host $result -ForegroundColor Red
        return $false;
    }
    Write-Host "✅ Created Resource Group $($resourceGroup)" -ForegroundColor Green
} else {
    Write-Host "✅ Resource Group ($resourceGroup) Exists" -ForegroundColor Green
}

Write-Host "👀 Running What-If on the Bicep file..." -ForegroundColor Cyan

az deployment group what-if `
    -g $resourceGroup `
    --template-file $bicepFile `
    --parameters @$tempParametersFile

if (!$?) {
    Write-Host "❌ What-if failed... aborting!" -ForegroundColor Red
    exit 1
}

if (!$dryRun.IsPresent) {
    Write-Host "🔨 Deploying Bicep" -ForegroundColor Yellow

    $output = (az deployment group create `
        -g $resourceGroup `
        --template-file $bicepFile `
        --name "deployment-$($deploymentTimestamp)" `
        --mode Incremental `
        --parameters @$tempParametersFile --query properties.outputs)

    if ($DebugPreference -ne "SilentlyContinue") {
        Write-Host $output -ForegroundColor Cyan
    }

    if (!$?) {
        Write-Host "❌ Deploying Bicep failed... aborting!" -ForegroundColor Red
        exit 1
    }

    $deploymentOutputs = $output | ConvertFrom-Json

    # Convert all the BICEP Output variables to DevOps Output variables that can be reused later in the pipeline
    # Note: to reference the output variable you need to prefix with the task "name" that executed this provision.ps1 file.
    Convert-ToDevOpsVariable -deploymentOutputs $deploymentOutputs
}

Write-Host
Write-Host "✅ Completed" -ForegroundColor Green