using Microsoft.EntityFrameworkCore.Migrations;

namespace thcp.Migrations
{
    public partial class neww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Position_Departments_DepartmetId",
                table: "Position");

            migrationBuilder.DropIndex(
                name: "IX_Position_DepartmetId",
                table: "Position");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDepartmetId",
                table: "Position",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Position_DepartmentDepartmetId",
                table: "Position",
                column: "DepartmentDepartmetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Position_Departments_DepartmentDepartmetId",
                table: "Position",
                column: "DepartmentDepartmetId",
                principalTable: "Departments",
                principalColumn: "DepartmetId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Position_Departments_DepartmentDepartmetId",
                table: "Position");

            migrationBuilder.DropIndex(
                name: "IX_Position_DepartmentDepartmetId",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "DepartmentDepartmetId",
                table: "Position");

            migrationBuilder.CreateIndex(
                name: "IX_Position_DepartmetId",
                table: "Position",
                column: "DepartmetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Position_Departments_DepartmetId",
                table: "Position",
                column: "DepartmetId",
                principalTable: "Departments",
                principalColumn: "DepartmetId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
