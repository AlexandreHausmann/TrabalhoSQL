using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroUsuario.Infrastructure.Migrations
{
    public partial class atulizcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Login",
                table: "UsuarioEntity",
                newName: "Email");

            migrationBuilder.AddColumn<int>(
                name: "CPF",
                table: "UsuarioEntity",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "UsuarioEntity");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "UsuarioEntity",
                newName: "Login");
        }
    }
}
