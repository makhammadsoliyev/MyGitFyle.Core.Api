using GitFyle.Core.Api.Models.Foundations.Contributions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitFyle.Core.Api.Brokers.Storages;

internal sealed partial class StorageBroker
{
    void AddContributionsConfigurations(EntityTypeBuilder<Contribution> builder)
    {
        builder.Property(contribution => contribution.RepositoryId)
            .IsRequired();

        builder.Property(contribution => contribution.ContributorId)
            .IsRequired();

        builder.Property(contribution => contribution.ContributionTypeId)
            .IsRequired();

        builder.Property(contribution => contribution.ExternalId)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(contribution => contribution.Title)
            .HasMaxLength(255)
            .IsRequired();
        
        builder.HasOne(contribution => contribution.Repository)
            .WithMany(repository => repository.Contributions)
            .HasForeignKey(contribution => contribution.RepositoryId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(contribution => contribution.Contributor)
            .WithMany(contributor => contributor.Contributions)
            .HasForeignKey(contribution => contribution.ContributorId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(contribution => contribution.ContributionType)
            .WithMany(contributionType => contributionType.Contributions)
            .HasForeignKey(contribution => contribution.ContributionTypeId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
