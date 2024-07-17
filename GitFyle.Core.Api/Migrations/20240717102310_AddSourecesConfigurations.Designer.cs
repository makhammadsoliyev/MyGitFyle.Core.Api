﻿// <auto-generated />
using System;
using GitFyle.Core.Api.Brokers.Storages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GitFyle.Core.Api.Migrations
{
    [DbContext(typeof(StorageBroker))]
    [Migration("20240717102310_AddSourecesConfigurations")]
    partial class AddSourecesConfigurations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.ContributionTypes.ContributionType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ContributionTypes");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Contributions.Contribution", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContributionTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContributorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("MergedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("RepositoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("ContributionTypeId");

                    b.HasIndex("ContributorId");

                    b.HasIndex("RepositoryId");

                    b.ToTable("Contributions");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Contributors.Contributor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("SourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("SourceId");

                    b.HasIndex("ExternalId", "SourceId", "Username")
                        .IsUnique();

                    b.ToTable("Contributors");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Repositories.Repository", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateadAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsOrganization")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("SourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("TokenExpireAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("UpdateadAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("SourceId");

                    b.HasIndex("Name", "Owner", "ExternalId", "SourceId")
                        .IsUnique();

                    b.ToTable("Repositories");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Sources.Source", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Contributions.Contribution", b =>
                {
                    b.HasOne("GitFyle.Core.Api.Models.Foundations.ContributionTypes.ContributionType", "ContributionType")
                        .WithMany("Contributions")
                        .HasForeignKey("ContributionTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("GitFyle.Core.Api.Models.Foundations.Contributors.Contributor", "Contributor")
                        .WithMany("Contributions")
                        .HasForeignKey("ContributorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("GitFyle.Core.Api.Models.Foundations.Repositories.Repository", "Repository")
                        .WithMany("Contributions")
                        .HasForeignKey("RepositoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ContributionType");

                    b.Navigation("Contributor");

                    b.Navigation("Repository");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Contributors.Contributor", b =>
                {
                    b.HasOne("GitFyle.Core.Api.Models.Foundations.Sources.Source", "Source")
                        .WithMany("Contributors")
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Source");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Repositories.Repository", b =>
                {
                    b.HasOne("GitFyle.Core.Api.Models.Foundations.Sources.Source", "Source")
                        .WithMany("Repositories")
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Source");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.ContributionTypes.ContributionType", b =>
                {
                    b.Navigation("Contributions");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Contributors.Contributor", b =>
                {
                    b.Navigation("Contributions");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Repositories.Repository", b =>
                {
                    b.Navigation("Contributions");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Sources.Source", b =>
                {
                    b.Navigation("Contributors");

                    b.Navigation("Repositories");
                });
#pragma warning restore 612, 618
        }
    }
}
