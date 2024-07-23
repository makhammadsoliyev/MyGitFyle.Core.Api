﻿using System.Linq;
using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.Repositories;

namespace GitFyle.Core.Api.Brokers.Storages;

public partial interface IStorageBroker
{
    ValueTask<Repository> InsertRepositoryAsync(Repository repository);
    IQueryable<Repository> SelectAllRepositories();
}
