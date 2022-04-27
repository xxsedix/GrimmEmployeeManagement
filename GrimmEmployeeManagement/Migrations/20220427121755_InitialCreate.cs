using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrimmEmployeeManagement.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeData",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Social = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartingDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clearence = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeData", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeData");
        }
    }
}
