using System.Linq;
using System.Threading.Tasks;
using EFxceptions;
using GitFyle.Core.Api.Models.Foundations.Contributions;
using GitFyle.Core.Api.Models.Foundations.ContributionTypes;
using GitFyle.Core.Api.Models.Foundations.Contributors;
using GitFyle.Core.Api.Models.Foundations.Repositories;
using GitFyle.Core.Api.Models.Foundations.Sources;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker : EFxceptionsContext, IStorageBroker
{
    private readonly IConfiguration configuration;

    public StorageBroker(IConfiguration configuration)
    {
        this.configuration = configuration;
        this.Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString =
            this.configuration.GetConnectionString(
                name: "DefaultConnection");

        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        AddSourcesConfigurations(modelBuilder.Entity<Source>());
        AddRepositoriesConfigurations(modelBuilder.Entity<Repository>());
        AddContributorsConfigurations(modelBuilder.Entity<Contributor>());
        AddContributionsConfigurations(modelBuilder.Entity<Contribution>());
        AddContributionTypesConfigurations(modelBuilder.Entity<ContributionType>());
    }

    private async ValueTask<T> InsertAsync<T>(T entity)
    {
        this.Entry(entity).State = EntityState.Added;
        await this.SaveChangesAsync();
        DetachEntity(entity);

        return entity;
    }

    private IQueryable<T> SelectAll<T>() where T : class
        => this.Set<T>();

    private void DetachEntity<T>(T entity)
    {
        this.Entry(entity).State = EntityState.Detached;
    }
}