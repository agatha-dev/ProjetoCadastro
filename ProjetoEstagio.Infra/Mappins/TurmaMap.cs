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
            builder.HasKey(u => u.Id);

            //mapeamento dos campos
            builder.Property(u => u.Id)
                    .HasColumnName("IdTurma");

            builder.Property(c => c.NomeCurso)
              .HasColumnName("Curso")
              .HasMaxLength(150)
              .IsRequired();

            builder.Property(c => c.NomeProfessor)
              .HasColumnName("NomeProfessor")
              .HasMaxLength(150)
              .IsRequired();

            builder.Property(c => c.Ementa)
              .HasColumnName("Ementa")
              .HasMaxLength(300)
              .IsRequired();
        }
    }
}
