using GitFyle.Core.Api.Models.Foundations.Sources;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    void AddSourcesConfigurations(EntityTypeBuilder<Source> builder)
    {
        builder.Property(source => source.Name)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(source => source.Url)
            .HasMaxLength(255)
            .IsRequired();

        builder.HasIndex(source => source.Name)
            .IsUnique();
    }
}
