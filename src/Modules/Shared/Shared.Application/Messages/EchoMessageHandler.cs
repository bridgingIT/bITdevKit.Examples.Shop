﻿namespace Modules.Shared.Application;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BridgingIT.DevKit.Application.Messaging;
using BridgingIT.DevKit.Common;
using Microsoft.Extensions.Logging;

public class EchoMessageHandler : MessageHandlerBase<EchoMessage>,
    IRetryMessageHandler,
    ITimeoutMessageHandler,
    IChaosExceptionMessageHandler
{
    public EchoMessageHandler(ILoggerFactory loggerFactory)
        : base(loggerFactory)
    {
    }

    RetryMessageHandlerOptions IRetryMessageHandler.Options => new() { Attempts = 3, Backoff = new TimeSpan(0, 0, 0, 1) };

    TimeoutMessageHandlerOptions ITimeoutMessageHandler.Options => new() { Timeout = new TimeSpan(0, 0, 0, 10) };

    ChaosExceptionMessageHandlerOptions IChaosExceptionMessageHandler.Options => new() { InjectionRate = 0.25 };

    /// <summary>
    /// Handles the specified message.
    /// </summary>
    /// <param name="message">The event.</param>
    public override async Task Handle(EchoMessage message, CancellationToken cancellationToken)
    {
        var loggerState = new Dictionary<string, object>
        {
            ["MessageId"] = message.Id,
        };

        using (this.Logger.BeginScope(loggerState))
        {
            await Task.Delay(300, cancellationToken);

            //throw new Exception("haha");
            this.Logger.LogInformation($"{{LogKey}} >>>>> SHARED echo {message.Text} (name={{MessageName}}, id={{MessageId}}, handler={{}}) ", Constants.LogKey, message.GetType().PrettyName(), message.Id, this.GetType().FullName);
        }
    }
}