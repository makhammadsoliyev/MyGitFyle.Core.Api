﻿using System;
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

    public async ValueTask<Repository> SelectRepositoryByIdAsync(Guid repositoryId)
        => await SelectAsync<Repository>(repositoryId);

    public async ValueTask<Repository> UpdateRepositoryAsync(Repository repository)
        => await UpdateAsync(repository);

    public async ValueTask<Repository> DeleteRepositoryAsync(Repository repository)
        => await DeleteAsync(repository);
}
