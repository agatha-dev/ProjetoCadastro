using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Contracts.Repositories;
using ProjetoEstagio.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Infra.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
         where TEntity : class
    {
        private readonly SqlContext _sqlContext;

        public BaseRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Delete(TEntity obj)
        {
            _sqlContext.Entry(obj).State = EntityState.Deleted;
            _sqlContext.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _sqlContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _sqlContext.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity obj)
        {
            _sqlContext.Entry(obj).State = EntityState.Added;
            _sqlContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _sqlContext.Entry(obj).State = EntityState.Modified;
            _sqlContext.SaveChanges();
        }
    }
}
