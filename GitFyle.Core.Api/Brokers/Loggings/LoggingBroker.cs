﻿using System;
using Microsoft.Extensions.Logging;

namespace GitFyle.Core.Api.Brokers.Loggings;

public sealed class LoggingBroker(ILogger logger) : ILoggingBroker
{
    public void LogInformation(string message)
        => logger.LogInformation(message);

    public void LogTrace(string message)
        => logger.LogTrace(message);

    public void LogDebug(string message)
        => logger.LogDebug(message);

    public void LogWarning(string message)
        => logger.LogWarning(message);

    public void LogError(Exception exception)
        => logger.LogError(exception, message: exception.Message);

    public void LogCritical(Exception exception)
        => logger.LogCritical(exception, message: exception.Message);
}
