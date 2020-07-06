using Microsoft.EntityFrameworkCore.Migrations;

namespace _ImproveHealth.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nvarchar250 = table.Column<string>(name: "nvarchar(250)", nullable: false),
                    varchar10 = table.Column<string>(name: "varchar(10)", nullable: true),
                    varchar100 = table.Column<string>(name: "varchar(100)", nullable: true),
                    OfficeLocation = table.Column<string>(nullable: true),
                    BloodType = table.Column<string>(nullable: true),
                    Allergies = table.Column<string>(nullable: true),
                    MedicalInsuranceNumber = table.Column<string>(nullable: true),
                    HeartDissease = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
