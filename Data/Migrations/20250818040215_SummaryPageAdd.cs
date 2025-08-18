using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeRazorApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SummaryPageAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoalsCompleted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumConfidentCompentencies = table.Column<int>(type: "int", nullable: false),
                    NumEmergingCompentencies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogbookCompleted = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summary", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Summary");
        }
    }
}
