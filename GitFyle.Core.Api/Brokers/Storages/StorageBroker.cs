﻿using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed class StorageBroker : EFxceptionsContext, IStorageBroker
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
}