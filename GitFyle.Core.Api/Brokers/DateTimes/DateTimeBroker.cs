using System;

namespace GitFyle.Core.Api.Brokers.DateTimes;

public sealed class DateTimeBroker : IDateTimeBroker
{
    public DateTimeOffset GetCurrentDateTimeOffset()
        => DateTimeOffset.UtcNow;
}