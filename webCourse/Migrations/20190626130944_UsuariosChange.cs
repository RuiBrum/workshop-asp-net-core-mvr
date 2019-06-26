using Microsoft.EntityFrameworkCore.Migrations;

namespace webCourse.Migrations
{
    public partial class UsuariosChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "id_tabelionato",
                table: "usuarios",
                maxLength: 1,
                nullable: true,
                defaultValue: "1",
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "id_tabelionato",
                table: "usuarios",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValue: "1");
        }
    }
}
