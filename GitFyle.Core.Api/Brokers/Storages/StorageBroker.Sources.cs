using System;
using System.Linq;
using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.Sources;
using Microsoft.EntityFrameworkCore;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    public DbSet<Source> Sources { get; set; }

    public async ValueTask<Source> InsertSourceAsync(Source source)
        => await InsertAsync(source);

    public IQueryable<Source> SelectAllSources()
        => SelectAll<Source>();

    public async ValueTask<Source> SelectSourceByIdAsync(Guid sourceId)
        => await SelectAsync<Source>(sourceId);

    public async ValueTask<Source> UpdateSourceAsync(Source source)
        => await UpdateAsync(source);

    public async ValueTask<Source> DeleteSourceAsync(Source source)
        => await DeleteAsync(source);
}
