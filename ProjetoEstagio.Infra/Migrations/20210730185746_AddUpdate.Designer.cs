﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoEstagio.Infra.Contexts;

namespace ProjetoEstagio.Infra.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20210730185746_AddUpdate")]
    partial class AddUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoEstagio.Domain.Entities.Aluno", b =>
                {
                    b.Property<Guid>("IdAluno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdAluno");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Endereco");

                    b.Property<Guid>("IdTurma")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdTurma");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Nome");

                    b.HasKey("IdAluno");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("IdTurma");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("ProjetoEstagio.Domain.Entities.Turma", b =>
                {
                    b.Property<Guid>("IdTurma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdTurma");

                    b.Property<string>("Ementa")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("Ementa");

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Curso");

                    b.Property<string>("NomeProfessor")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("NomeProfessor");

                    b.HasKey("IdTurma");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("ProjetoEstagio.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("date")
                        .HasColumnName("DataCriacao");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Login");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Senha");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoEstagio.Domain.Entities.Aluno", b =>
                {
                    b.HasOne("ProjetoEstagio.Domain.Entities.Turma", "Turma")
                        .WithMany("Alunos")
                        .HasForeignKey("IdTurma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("ProjetoEstagio.Domain.Entities.Turma", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
