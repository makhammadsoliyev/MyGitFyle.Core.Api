﻿using System;
using System.Linq;
using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.Repositories;

namespace GitFyle.Core.Api.Brokers.Storages;

internal partial interface IStorageBroker
{
    ValueTask<Repository> InsertRepositoryAsync(Repository repository);
    IQueryable<Repository> SelectAllRepositories();
    ValueTask<Repository> SelectRepositoryByIdAsync(Guid repositoryId);
    ValueTask<Repository> UpdateRepositoryAsync(Repository repository);
    ValueTask<Repository> DeleteRepositoryAsync(Repository repository);
}
