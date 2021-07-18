using ProjetoEstagio.Domain.Entities;
using ProjetoEstagio.Domain.Interfaces.Repositors;
using ProjetoEstagio.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Infra.Repositories
{
    public class TurmaRepository : BaseRepository<Turma>, ITurmaRepository
    {
        private readonly SqlContext sqlContext;

        public TurmaRepository(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext; 
        }
    }
}
