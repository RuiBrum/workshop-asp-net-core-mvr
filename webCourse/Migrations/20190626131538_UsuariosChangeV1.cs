using Microsoft.EntityFrameworkCore.Migrations;

namespace webCourse.Migrations
{
    public partial class UsuariosChangeV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "id_tabelionato",
                table: "usuarios",
                maxLength: 1,
                nullable: false,
                defaultValue: "1",
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "1");

            migrationBuilder.CreateIndex(
                name: "Ix_UsuarioLogin",
                table: "usuarios",
                column: "login");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Ix_UsuarioLogin",
                table: "usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "id_tabelionato",
                table: "usuarios",
                maxLength: 1,
                nullable: true,
                defaultValue: "1",
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldDefaultValue: "1");
        }
    }
}
