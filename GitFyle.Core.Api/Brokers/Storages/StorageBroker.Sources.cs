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
}
