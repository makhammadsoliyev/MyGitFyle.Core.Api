using System.Linq;
using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    public DbSet<Repository> Repositories { get; set; }

    public async ValueTask<Repository> InsertRepositoryAsync(Repository repository)
        => await InsertAsync(repository);

    public IQueryable<Repository> SelectAllRepositories()
        => SelectAll<Repository>();
}
