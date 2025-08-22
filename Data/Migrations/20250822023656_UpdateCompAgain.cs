using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeRazorApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCompAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompaniesContact",
                table: "CDL");

            migrationBuilder.DropColumn(
                name: "ElevatorPitch",
                table: "CDL");

            migrationBuilder.DropColumn(
                name: "Questions",
                table: "CDL");

            migrationBuilder.DropColumn(
                name: "UpcomingEvents",
                table: "CDL");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "CDL",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElevatorPitch",
                table: "CDL",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Questions",
                table: "CDL",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpcomingEvents",
                table: "CDL",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
