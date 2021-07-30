using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Infra.Mappins
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            //nome da tabela
            builder.ToTable("Aluno");

            //chave primária
            builder.HasKey(u => u.Id);

            //mapeamento dos campos
            builder.Property(a => a.Id)
                    .HasColumnName("IdAluno");

            builder.Property(a => a.IdTurma)
                    .HasColumnName("IdTurma");

            builder.Property(n => n.Nome)
                  .HasColumnName("Nome")
                  .HasMaxLength(150)
                  .IsRequired();

            builder.Property(C => C.Cpf)
                .HasColumnName("Cpf")
                 .HasMaxLength(150)
                .IsRequired();

            builder.Property(e => e.Endereco)
                .HasColumnName("Endereco")
                 .HasMaxLength(150)
                 .IsRequired();

            builder.Property(m => m.Email)
                .HasColumnName("Email")
                .HasMaxLength(150)
                .IsRequired();

            #region Relacionamentos

            builder.HasOne(x => x.Turma) //Aluno TEM 1 Turma
                .WithMany(x => x.Alunos) //Turmas TEM N Aluno
                .HasForeignKey(x => x.IdTurma); //Chave estrangeira

            #endregion

        }
    }
}
