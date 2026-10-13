using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trainings_Logger.Migrations
{
    /// <inheritdoc />
    public partial class AddIsBodyweight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isBodyweight",
                table: "Exercises",
                newName: "IsBodyweight");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsBodyweight",
                table: "Exercises",
                newName: "isBodyweight");
        }
    }
}
