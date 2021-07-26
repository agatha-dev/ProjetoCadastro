using Projeto.Domain.Contracts.Repositories;
using ProjetoEstagio.Domain.Interfaces.Repositors;
using System;

namespace ProjetoEstagio.Domain.Interfaces.Services
{
    public interface IUnitOfWork : IDisposable
    {
        #region Repositories

        ITurmaRepository TurmaRepository { get; }
        IAlunoRepository AlunoRepository { get; }
        

        #endregion

        #region Transactions

        void BeginTransaction();
        void Commit();
        void Rollback();

        #endregion
    }
}
