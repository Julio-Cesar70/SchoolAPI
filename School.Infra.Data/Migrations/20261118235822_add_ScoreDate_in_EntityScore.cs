using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class add_ScoreDate_in_EntityScore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ScoreDate",
                table: "Score",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScoreDate",
                table: "Score");
        }
    }
}
