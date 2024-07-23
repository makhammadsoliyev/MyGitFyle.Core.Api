using System;
using System.Linq;
using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.Contributors;

namespace GitFyle.Core.Api.Brokers.Storages;

internal partial interface IStorageBroker
{
    ValueTask<Contributor> InsertContributorAsync(Contributor contributor);
    IQueryable<Contributor> SelectAllContributors();
    ValueTask<Contributor> SelectContributorByIdAsync(Guid contributorId);
    ValueTask<Contributor> UpdateContributorAsync(Contributor contributor);
}
