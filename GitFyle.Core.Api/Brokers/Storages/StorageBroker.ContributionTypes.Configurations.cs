using GitFyle.Core.Api.Models.Foundations.ContributionTypes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    void AddContributionTypesConfigurations(EntityTypeBuilder<ContributionType> builder)
    {
        builder.Property(contributionType => contributionType.Name)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(contributionType => contributionType.Value)
            .IsRequired();

        builder.HasIndex(contributionType => contributionType.Name)
            .IsUnique();
    }
}
