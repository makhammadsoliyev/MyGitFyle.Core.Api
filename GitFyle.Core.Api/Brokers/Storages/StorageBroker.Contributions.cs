using System;
using System.Linq;
using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.Contributions;
using Microsoft.EntityFrameworkCore;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    public DbSet<Contribution> Contributions { get; set; }

    public async ValueTask<Contribution> InsertContributionAsync(Contribution contribution)
        => await InsertAsync(contribution);

    public IQueryable<Contribution> SelectAllContributions()
        => SelectAll<Contribution>();

    public async ValueTask<Contribution> SelectContributionByIdAsync(Guid contributionId)
        => await SelectAsync<Contribution>(contributionId);

    public async ValueTask<Contribution> UpdateContributionAsync(Contribution contribution)
        => await UpdateAsync(contribution);

    public async ValueTask<Contribution> DeleteContributionAsync(Contribution contribution)
        => await DeleteAsync(contribution);
}
