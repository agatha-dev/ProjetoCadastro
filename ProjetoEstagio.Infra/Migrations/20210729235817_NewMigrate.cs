using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoEstagio.Infra.Migrations
{
    public partial class NewMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    IdAluno = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.IdAluno);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    IdTurma = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAluno = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Curso = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.IdTurma);
                    table.ForeignKey(
                        name: "FK_Turma_Aluno_IdAluno",
                        column: x => x.IdAluno,
                        principalTable: "Aluno",
                        principalColumn: "IdAluno",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_Email",
                table: "Aluno",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Turma_IdAluno",
                table: "Turma",
                column: "IdAluno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Aluno");
        }
    }
}
