using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.Contributors;

namespace GitFyle.Core.Api.Brokers.Storages;

internal partial interface IStorageBroker
{
    ValueTask<Contributor> InsertContributorAsync(Contributor contributor);
}
