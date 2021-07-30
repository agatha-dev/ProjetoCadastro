using Microsoft.EntityFrameworkCore;
using Projeto.Domain;
using Projeto.Domain.Contracts.Repositories;
using ProjetoEstagio.Domain.Entities;
using ProjetoEstagio.Infra.Contexts;
using ProjetoEstagio.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        private readonly SqlContext sqlContext;

        public AlunoRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public Aluno GetEmail(string email)
        {
            return sqlContext.Aluno
                .FirstOrDefault(a => a.Email.Equals(email));
        }

        public override List<Aluno> GetAll()
        {
            return sqlContext
                .Aluno
                .Include(f => f.Turma) //LEFT JOIN
                .ToList();
        }

        public override Aluno GetById(Guid id)
        {
            return sqlContext
                .Aluno
                .Include(f => f.Turma) //LEFT JOIN
                .FirstOrDefault(f => f.Id == id);
        }
    }
}