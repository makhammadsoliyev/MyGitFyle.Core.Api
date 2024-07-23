using System.Linq;
using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.Contributors;
using Microsoft.EntityFrameworkCore;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    public DbSet<Contributor> Contributors { get; set; }

    public async ValueTask<Contributor> InsertContributorAsync(Contributor contributor)
        => await InsertAsync(contributor);

    public IQueryable<Contributor> SelectAllContributors()
        => SelectAll<Contributor>();
}
