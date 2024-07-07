using GitFyle.Core.Api.Models.Foundations.Contributors;
using Microsoft.EntityFrameworkCore;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    public DbSet<Contributor> Contributors { get; set; }
}
