using Microsoft.EntityFrameworkCore.Migrations;

namespace thcp.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentEdad",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentEducacion",
                table: "Departments",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentEspecialidad",
                table: "Departments",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentIdioma",
                table: "Departments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentPuesto",
                table: "Departments",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentRecursos",
                table: "Departments",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentSalario",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentSexo",
                table: "Departments",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentTelefono",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentEdad",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentEducacion",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentEspecialidad",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentIdioma",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentPuesto",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentRecursos",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentSalario",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentSexo",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentTelefono",
                table: "Departments");
        }
    }
}
