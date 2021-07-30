using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoEstagio.Infra.Migrations
{
    public partial class AddUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ementa",
                table: "Turma",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeProfessor",
                table: "Turma",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ementa",
                table: "Turma");

            migrationBuilder.DropColumn(
                name: "NomeProfessor",
                table: "Turma");
        }
    }
}
