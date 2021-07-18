using Microsoft.EntityFrameworkCore;
using ProjetoEstagio.Domain.Entities;
using ProjetoEstagio.Infra.Mappins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Infra.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());

            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasIndex(u => u.Email).IsUnique();

            });

        }
    }
}
