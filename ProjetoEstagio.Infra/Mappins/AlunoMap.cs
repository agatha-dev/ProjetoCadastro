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
            builder.HasKey(u => u.IdAlunos);

            //mapeamento dos campos
            builder.Property(a => a.IdAlunos)
                    .HasColumnName("IdAluno");

            builder.Property(n => n.nome)
                  .HasColumnName("Nome")
                  .HasMaxLength(150)
                  .IsRequired();

            builder.Property(M => M.IdMatricula)
                  .HasColumnName("IdMatricula")
                  .IsRequired();

            builder.Property(T => T.IdTurma)
                  .HasColumnName("idTurma")
                  .IsRequired();

            builder.Property(C => C.Cpf)
                .HasColumnName("cpf")
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

            builder.HasOne(t => t.Turma)  //Aluno tem 1 turma
                 .WithMany(a => a.Alunos) //Turma TEM N Alunos
                 .HasForeignKey(T => T.IdTurma);  //Chave estrangeira
            #endregion


        }
    }
}
