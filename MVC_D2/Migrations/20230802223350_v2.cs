using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_D2.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_office_Off_Id",
                table: "employee");

            migrationBuilder.AlterColumn<int>(
                name: "Off_Id",
                table: "employee",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_employee_office_Off_Id",
                table: "employee",
                column: "Off_Id",
                principalTable: "office",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_office_Off_Id",
                table: "employee");

            migrationBuilder.AlterColumn<int>(
                name: "Off_Id",
                table: "employee",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_employee_office_Off_Id",
                table: "employee",
                column: "Off_Id",
                principalTable: "office",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
