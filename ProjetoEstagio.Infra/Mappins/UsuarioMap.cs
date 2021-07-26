using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstagio.Domain.Entities;

namespace Projeto01.Infra.Data.SqlServer.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            //nome da tabela
            builder.ToTable("Usuario");

            //chave primária
            builder.HasKey(u => u.IdUsuario);

            //mapeamento dos campos
            builder.Property(u => u.IdUsuario)
                .HasColumnName("Id");

            builder.Property(u => u.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(l => l.Login)
                .HasColumnName("Login")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(u => u.Senha)
                .HasColumnName("Senha")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(u => u.DataCriacao)
                .HasColumnName("DataCriacao")
                .HasColumnType("date")
                .IsRequired();
        }
    }
}