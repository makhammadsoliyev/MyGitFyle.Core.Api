using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitFyle.Core.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddContributionType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Repositories_Name_Owner_ExternalId_SourceId",
                table: "Repositories");

            migrationBuilder.DropIndex(
                name: "IX_Contributors_ExternalId_SourceId_Username",
                table: "Contributors");

            migrationBuilder.CreateTable(
                name: "ContributionTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContributionTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_Name_Owner_ExternalId_SourceId",
                table: "Repositories",
                columns: new[] { "Name", "Owner", "ExternalId", "SourceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contributors_ExternalId_SourceId_Username",
                table: "Contributors",
                columns: new[] { "ExternalId", "SourceId", "Username" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContributionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Repositories_Name_Owner_ExternalId_SourceId",
                table: "Repositories");

            migrationBuilder.DropIndex(
                name: "IX_Contributors_ExternalId_SourceId_Username",
                table: "Contributors");

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_Name_Owner_ExternalId_SourceId",
                table: "Repositories",
                columns: new[] { "Name", "Owner", "ExternalId", "SourceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Contributors_ExternalId_SourceId_Username",
                table: "Contributors",
                columns: new[] { "ExternalId", "SourceId", "Username" });
        }
    }
}
