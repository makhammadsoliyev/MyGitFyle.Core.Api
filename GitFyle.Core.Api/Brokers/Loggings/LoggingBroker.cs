using Microsoft.Extensions.Logging;

namespace GitFyle.Core.Api.Brokers.Loggings;

public sealed class LoggingBroker(ILogger logger) : ILoggingBroker
{
    public void LogInformation(string message)
        => logger.LogInformation(message);
}
