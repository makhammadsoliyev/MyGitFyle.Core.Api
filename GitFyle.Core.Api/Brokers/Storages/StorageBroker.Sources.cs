using GitFyle.Core.Api.Models.Foundations.Sources;
using Microsoft.EntityFrameworkCore;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    public DbSet<Source> Sources { get; set; }
}
