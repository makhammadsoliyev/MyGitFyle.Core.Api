﻿using GitFyle.Core.Api.Models.Foundations.ContributionTypes;
using Microsoft.EntityFrameworkCore;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    public DbSet<ContributionType> ContributionTypes { get; set; }
}
