using Microsoft.EntityFrameworkCore.Migrations;

namespace thcp.Migrations
{
    public partial class Actual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentDetalle",
                table: "Departments",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentDetalle",
                table: "Departments");
        }
    }
}
