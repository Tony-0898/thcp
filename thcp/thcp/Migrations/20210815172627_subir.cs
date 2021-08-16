using Microsoft.EntityFrameworkCore.Migrations;

namespace thcp.Migrations
{
    public partial class subir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentNumero",
                table: "Departments",
                type: "int",
                maxLength: 70,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentNumero",
                table: "Departments");
        }
    }
}
