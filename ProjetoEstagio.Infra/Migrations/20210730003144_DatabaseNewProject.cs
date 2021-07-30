using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoEstagio.Infra.Migrations
{
    public partial class DatabaseNewProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turma_Aluno_IdAluno",
                table: "Turma");

            migrationBuilder.DropIndex(
                name: "IX_Turma_IdAluno",
                table: "Turma");

            migrationBuilder.DropColumn(
                name: "IdAluno",
                table: "Turma");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Aluno",
                newName: "Cpf");

            migrationBuilder.AddColumn<Guid>(
                name: "IdTurma",
                table: "Aluno",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_IdTurma",
                table: "Aluno",
                column: "IdTurma");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Turma_IdTurma",
                table: "Aluno",
                column: "IdTurma",
                principalTable: "Turma",
                principalColumn: "IdTurma",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Turma_IdTurma",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_IdTurma",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "IdTurma",
                table: "Aluno");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Aluno",
                newName: "cpf");

            migrationBuilder.AddColumn<Guid>(
                name: "IdAluno",
                table: "Turma",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Turma_IdAluno",
                table: "Turma",
                column: "IdAluno");

            migrationBuilder.AddForeignKey(
                name: "FK_Turma_Aluno_IdAluno",
                table: "Turma",
                column: "IdAluno",
                principalTable: "Aluno",
                principalColumn: "IdAluno",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
