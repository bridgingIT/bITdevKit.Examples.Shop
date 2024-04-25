//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 612 // Disable "CS0612 '...' is obsolete"
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"
#pragma warning disable 8604 // Disable "CS8604 Possible null reference argument for parameter"
#pragma warning disable 8625 // Disable "CS8625 Cannot convert null literal to non-nullable reference type"
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).

namespace Modules.Identity.Presentation.Web.Controllers
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]

    public abstract class IdentityControllerBase : Microsoft.AspNetCore.Mvc.Controller
    {
        /// <summary>
        /// Gets an echo
        /// </summary>
        /// <returns>OK</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/echo", Name = "Identity_Echo-Get")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> EchoGet();

        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/accounts/profile", Name = "Identity_Account-GetProfile")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfUserResponseModel>> AccountGetProfile();

        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("api/identity/accounts/UpdateProfile", Name = "Identity_Account-UpdateProfile")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> AccountUpdateProfile([Microsoft.AspNetCore.Mvc.FromBody] UpdateProfileRequestModel model);

        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("api/identity/accounts/ChangePassword", Name = "Identity_Account-ChangePassword")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> AccountChangePassword([Microsoft.AspNetCore.Mvc.FromBody] ChangePasswordRequestModel model);

        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/accounts/profile-picture/{userId}", Name = "Identity_Account-GetProfilePicture")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfStringResponseModel>> AccountGetProfilePicture(string userId);

        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("api/identity/accounts/profile-picture/{userId}", Name = "Identity_Account-UpdateProfilePicture")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfStringResponseModel>> AccountUpdateProfilePicture(string userId, [Microsoft.AspNetCore.Mvc.FromBody] UpdateProfilePictureRequestModel model);

        /// <summary>
        /// Acquire an access token
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("api/identity/tokens", Name = "Identity_Token-Acquire")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfTokenResponseModel>> TokenAcquire([Microsoft.AspNetCore.Mvc.FromBody] TokenRequestModel model);

        /// <summary>
        /// Acquire a refresh token
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("api/identity/tokens/refresh", Name = "Identity_Token-Refresh")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfTokenResponseModel>> TokenRefresh([Microsoft.AspNetCore.Mvc.FromBody] TokenRefreshRequestModel model);

        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/users", Name = "Identity_User-GetAll")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfUsersResponseModel>> UserGetAll();

        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("api/identity/users", Name = "Identity_User-Register")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> UserRegister([Microsoft.AspNetCore.Mvc.FromBody] RegisterRequestModel model);

        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("api/identity/users", Name = "Identity_User-Delete")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> UserDelete([Microsoft.AspNetCore.Mvc.FromQuery] string id);

        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/users/{id}", Name = "Identity_User-GetById")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfUserResponseModel>> UserGetById(string id);

        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/users/roles/{id}", Name = "Identity_User-GetRoles")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfUserRolesResponseModel>> UserGetRoles(string id);

        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("api/identity/users/roles/{id}", Name = "Identity_User-UpdateRoles")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> UserUpdateRoles(string id, [Microsoft.AspNetCore.Mvc.FromBody] UpdateUserRolesRequestModel model);

        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/users/confirm-email", Name = "Identity_User-ConfirmEmail")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfStringResponseModel>> UserConfirmEmail([Microsoft.AspNetCore.Mvc.FromQuery] string userId, [Microsoft.AspNetCore.Mvc.FromQuery] string code);

        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("api/identity/users/toggle-status", Name = "Identity_User-ToggleUserStatus")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> UserToggleUserStatus([Microsoft.AspNetCore.Mvc.FromBody] ToggleUserStatusRequestModel model);

        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("api/identity/users/forgot-password", Name = "Identity_User-ForgotPassword")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> UserForgotPassword([Microsoft.AspNetCore.Mvc.FromBody] ForgotPasswordRequestModel model);

        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("api/identity/users/reset-password", Name = "Identity_User-ResetPassword")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> UserResetPassword([Microsoft.AspNetCore.Mvc.FromBody] ResetPasswordRequestModel model);

        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/users/export", Name = "Identity_User-Export")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfStringResponseModel>> UserExport([Microsoft.AspNetCore.Mvc.FromQuery] string searchString = "");

        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/roles", Name = "Identity_Role-GetAll")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfRolesResponseModel>> RoleGetAll();

        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("api/identity/roles", Name = "Identity_Role-Create")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> RoleCreate([Microsoft.AspNetCore.Mvc.FromBody] RoleRequestModel model);

        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("api/identity/roles/{id}", Name = "Identity_Role-Delete")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> RoleDelete(string id);

        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/roles/permissions/{roleId}", Name = "Identity_Role-GetPermissionsByRoleId")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfPermissionResponseModel>> RoleGetPermissionsByRoleId(string roleId);

        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("api/identity/roles/permissions/update", Name = "Identity_Role-Update")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> RoleUpdate([Microsoft.AspNetCore.Mvc.FromBody] PermissionRequestModel model);

        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/roleclaims", Name = "Identity_RoleClaim-GetAll")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfRoleClaimsResponseModel>> RoleClaimGetAll();

        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("api/identity/roleclaims", Name = "Identity_RoleClaim-Create")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> RoleClaimCreate([Microsoft.AspNetCore.Mvc.FromBody] RoleClaimRequestModel request);

        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("api/identity/roleclaims/{roleId}", Name = "Identity_RoleClaim-GetAllByRoleId")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultOfRoleClaimsResponseModel>> RoleClaimGetAllByRoleId(string roleId);

        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("api/identity/roleclaims/{id}", Name = "Identity_RoleClaim-Delete")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResultResponseModel>> RoleClaimDelete(int id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResultResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("messages")]
        public System.Collections.Generic.IEnumerable<string> Messages { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("isSuccess")]
        public bool IsSuccess { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResultOfStringResponseModel : ResultResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ProblemDetailsModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string Detail { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("instance")]
        public string Instance { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ValidationProblemDetailsModel : ProblemDetailsModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("errors")]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IEnumerable<string>> Errors { get; set; } = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateProfileRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("firstName")]
        [System.ComponentModel.DataAnnotations.Required]
        public string FirstName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("lastName")]
        [System.ComponentModel.DataAnnotations.Required]
        public string LastName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ChangePasswordRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("password")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("newPassword")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NewPassword { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("confirmNewPassword")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ConfirmNewPassword { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateProfilePictureRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string FileName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("extension")]
        public string Extension { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[] Data { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResultOfTokenResponseModel : ResultResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public TokenResponseModel Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TokenResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("userImageURL")]
        public string UserImageURL { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("refreshTokenExpiryTime")]
        public System.DateTimeOffset RefreshTokenExpiryTime { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TokenRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string Password { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TokenRefreshRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResultOfUsersResponseModel : ResultResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public System.Collections.Generic.IEnumerable<UserResponseModel> Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UserResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string UserName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("isActive")]
        public bool IsActive { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("emailConfirmed")]
        public bool EmailConfirmed { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public System.Collections.Generic.IEnumerable<string> Permissions { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResultOfUserResponseModel : ResultResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public UserResponseModel Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResultOfUserRolesResponseModel : ResultResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public UserRolesResponseModel Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UserRolesResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("userRoles")]
        public System.Collections.Generic.IEnumerable<UserRoleModel> UserRoles { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UserRoleModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("roleName")]
        public string RoleName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("roleDescription")]
        public string RoleDescription { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("selected")]
        public bool Selected { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UpdateUserRolesRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string UserId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("userRoles")]
        public System.Collections.Generic.IEnumerable<UserRoleModel> UserRoles { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RegisterRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("firstName")]
        [System.ComponentModel.DataAnnotations.Required]
        public string FirstName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("lastName")]
        [System.ComponentModel.DataAnnotations.Required]
        public string LastName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Email { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("userName")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 6)]
        public string UserName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("password")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 6)]
        public string Password { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("confirmPassword")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ConfirmPassword { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("activateUser")]
        public bool ActivateUser { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("autoConfirmEmail")]
        public bool AutoConfirmEmail { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ToggleUserStatusRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("activateUser")]
        public bool ActivateUser { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string UserId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ForgotPasswordRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Email { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResetPasswordRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Email { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("password")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("confirmPassword")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ConfirmPassword { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("token")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Token { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResultOfRolesResponseModel : ResultResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public System.Collections.Generic.IEnumerable<RoleResponseModel> Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RoleResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RoleRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResultOfPermissionResponseModel : ResultResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public PermissionResponseModel Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PermissionResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("roleId")]
        public string RoleId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("roleName")]
        public string RoleName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("roleClaims")]
        public System.Collections.Generic.IEnumerable<RoleClaimResponseModel> RoleClaims { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PermissionRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("roleId")]
        public string RoleId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("roleClaims")]
        public System.Collections.Generic.IEnumerable<RoleClaimRequestModel> RoleClaims { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ResultOfRoleClaimsResponseModel : ResultResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public System.Collections.Generic.IEnumerable<RoleClaimResponseModel> Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RoleClaimResponseModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("roleId")]
        public string RoleId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("module")]
        public string Module { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("group")]
        public string Group { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("selected")]
        public bool Selected { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.7.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class RoleClaimRequestModel
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("roleId")]
        public string RoleId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("group")]
        public string Group { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("selected")]
        public bool Selected { get; set; }

    }


}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8603
#pragma warning restore 8604
#pragma warning restore 8625