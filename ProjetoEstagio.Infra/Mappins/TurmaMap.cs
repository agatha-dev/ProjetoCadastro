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
    public class TurmaMap : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            //nome da tabela
            builder.ToTable("Turma");

            //chave primária
            builder.HasKey(u => u.IdTurma);

            //mapeamento dos campos
            builder.Property(u => u.IdTurma)
                    .HasColumnName("IdTurma");

            builder.Property(f => f.IdAluno)
               .HasColumnName("IdAluno")
               .IsRequired();

            builder.Property(c => c.Curso)
              .HasColumnName("Curso")
              .HasMaxLength(150)
              .IsRequired();
        }
    }
}
