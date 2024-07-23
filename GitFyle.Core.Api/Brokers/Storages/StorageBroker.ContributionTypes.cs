﻿using System.Linq;
using System.Threading.Tasks;
using GitFyle.Core.Api.Models.Foundations.ContributionTypes;
using Microsoft.EntityFrameworkCore;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    public DbSet<ContributionType> ContributionTypes { get; set; }

    public async ValueTask<ContributionType> InsertContributionTypeAsync(ContributionType contributionType)
        => await InsertAsync(contributionType);

    public IQueryable<ContributionType> SelectAllContributionTypes()
        => SelectAll<ContributionType>();
}
