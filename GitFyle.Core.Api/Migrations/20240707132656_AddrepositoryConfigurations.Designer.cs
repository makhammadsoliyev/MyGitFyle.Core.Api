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
    [Migration("20240707132656_AddrepositoryConfigurations")]
    partial class AddrepositoryConfigurations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.HasIndex("Name", "Owner", "ExternalId", "SourceId");

                    b.ToTable("Repositories");
                });

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Sources.Source", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sources");
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

            modelBuilder.Entity("GitFyle.Core.Api.Models.Foundations.Sources.Source", b =>
                {
                    b.Navigation("Repositories");
                });
#pragma warning restore 612, 618
        }
    }
}
