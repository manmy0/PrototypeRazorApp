using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeRazorApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCDLPage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
