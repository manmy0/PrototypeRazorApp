using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeRazorApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class GoalsPageAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionalInterests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployersOfInterest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DevelopmentFocus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmartGoal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionSteps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timeline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgressNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyLearnings = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goals");
        }
    }
}
