using System;
using System.Linq;
using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.Sources;

namespace GitFyle.Core.Api.Brokers.Storages;

internal partial interface IStorageBroker
{
    ValueTask<Source> InsertSourceAsync(Source source);
    IQueryable<Source> SelectAllSources();
    ValueTask<Source> SelectSourceByIdAsync(Guid sourceId);
    ValueTask<Source> UpdateSourceAsync(Source source);
}
