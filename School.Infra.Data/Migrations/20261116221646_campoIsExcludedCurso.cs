using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class campoIsExcludedCurso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "Course",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "Course");
        }
    }
}
