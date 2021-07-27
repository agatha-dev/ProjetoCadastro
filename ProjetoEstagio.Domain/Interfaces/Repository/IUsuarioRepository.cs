using Projeto.Domain.Contracts.Repositories;
using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario GetByLogin(string login);
        Usuario GetByLoginAndPassword(string login, string password);
    }
}
