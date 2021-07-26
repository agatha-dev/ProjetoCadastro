using Microsoft.EntityFrameworkCore;
using Projeto01.Infra.Data.SqlServer.Mappings;
using ProjetoEstagio.Domain.Entities;
using ProjetoEstagio.Infra.Mappins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Infra.Contexts
{
    public class DataContext : SqlContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<UsuarioEntity> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            

            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasIndex(a => a.Email).IsUnique();
            });

            modelBuilder.Entity<UsuarioEntity>(entity =>
            {
                entity.HasIndex(u => u.Login).IsUnique();
            });

        }
    }
}
