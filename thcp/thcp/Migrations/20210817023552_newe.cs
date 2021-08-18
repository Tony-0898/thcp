using Microsoft.EntityFrameworkCore.Migrations;

namespace thcp.Migrations
{
    public partial class newe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionBeneficios",
                table: "Position",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionContacto",
                table: "Position",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionDepartamento",
                table: "Position",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionDetalles",
                table: "Position",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionExperiencia",
                table: "Position",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionJornada",
                table: "Position",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionPerfil",
                table: "Position",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DescriptionSalario",
                table: "Position",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionTipoContrato",
                table: "Position",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionZona",
                table: "Position",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionBeneficios",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "DescriptionContacto",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "DescriptionDepartamento",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "DescriptionDetalles",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "DescriptionExperiencia",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "DescriptionJornada",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "DescriptionPerfil",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "DescriptionSalario",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "DescriptionTipoContrato",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "DescriptionZona",
                table: "Position");
        }
    }
}
