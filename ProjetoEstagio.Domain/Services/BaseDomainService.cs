using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using ProjetoEstagio.Domain.Interfaces.Repositors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class BaseDomainService<T> : IBaseDomainService<T>
        where T : class
    {

        private readonly IBaseRepository<T> baseRepository;
        private ITurmaRepository TurmaRepository;

        public BaseDomainService(IBaseRepository<T> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public BaseDomainService(ITurmaRepository turmaRepository)
        {
            this.TurmaRepository = turmaRepository;
        }

        public virtual void Delete(T obj)
        {
            baseRepository.Delete(obj);
        }

        public virtual List<T> GetAll()
        {
            return baseRepository.GetAll();
        }

        public virtual T GetById(Guid id)
        {
            return baseRepository.GetById(id);
        }


        public virtual void Insert(T obj)
        {
            baseRepository.Insert(obj);
        }

        public virtual void Update(T obj)
        {
            baseRepository.Update(obj);
        }
    }
}