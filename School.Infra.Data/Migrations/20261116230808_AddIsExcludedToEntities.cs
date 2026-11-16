using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsExcludedToEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "User",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "Score",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "Registration",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "Class",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "Registration");

            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "Class");
        }
    }
}
