using ProjetoEstagio.Domain.Entities;
using ProjetoEstagio.Domain.Interfaces.Repository;
using ProjetoEstagio.Infra.Contexts;
using ProjetoEstagio.Infra.Repositories;
using System;
using System.Linq;

namespace Projeto01.Infra.Data.SqlServer.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly SqlContext _sqlContext;

        public UsuarioRepository(SqlContext sqlContext)
            : base(sqlContext)
        {
            this._sqlContext = sqlContext;
        }

        public Usuario GetByLogin(string login)
        {
            return _sqlContext.Usuario
                .FirstOrDefault(u => u.Login.Equals(login));
        }

        public Usuario GetByLoginAndPassword(string login, string password)
        {
            return _sqlContext.Usuario
                .FirstOrDefault(u => u.Login.Equals(login) && u.Senha.Equals(password));
        }
    }
}