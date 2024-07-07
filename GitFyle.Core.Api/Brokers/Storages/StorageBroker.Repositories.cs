using GitFyle.Core.Api.Models.Foundations.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    public DbSet<Repository> Repositories { get; set; }
}
