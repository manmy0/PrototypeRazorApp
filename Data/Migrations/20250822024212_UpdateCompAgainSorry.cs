using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeRazorApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCompAgainSorry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompaniesContact",
                table: "Competencies");

            migrationBuilder.DropColumn(
                name: "ElevatorPitch",
                table: "Competencies");

            migrationBuilder.DropColumn(
                name: "Questions",
                table: "Competencies");

            migrationBuilder.DropColumn(
                name: "UpcomingEvents",
                table: "Competencies");

            migrationBuilder.AddColumn<string>(
                name: "CompaniesContact",
                table: "Networking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElevatorPitch",
                table: "Networking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Questions",
                table: "Networking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpcomingEvents",
                table: "Networking",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompaniesContact",
                table: "Networking");

            migrationBuilder.DropColumn(
                name: "ElevatorPitch",
                table: "Networking");

            migrationBuilder.DropColumn(
                name: "Questions",
                table: "Networking");

            migrationBuilder.DropColumn(
                name: "UpcomingEvents",
                table: "Networking");

            migrationBuilder.AddColumn<string>(
                name: "CompaniesContact",
                table: "Competencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElevatorPitch",
                table: "Competencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Questions",
                table: "Competencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpcomingEvents",
                table: "Competencies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
