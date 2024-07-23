using System;
using System.Linq;
using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.ContributionTypes;

namespace GitFyle.Core.Api.Brokers.Storages;

internal partial interface IStorageBroker
{
    ValueTask<ContributionType> InsertContributionTypeAsync(ContributionType contributionType);
    IQueryable<ContributionType> SelectAllContributionTypes();
    ValueTask<ContributionType> SelectContributionTypeByIdAsync(Guid contributionTypeId);
    ValueTask<ContributionType> UpdateContributionTypeAsync(ContributionType contributionType);
    ValueTask<ContributionType> DeleteContributionTypeAsync(ContributionType contributionType);
}
