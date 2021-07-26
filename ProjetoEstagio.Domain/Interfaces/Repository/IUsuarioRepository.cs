using Projeto.Domain.Contracts.Repositories;
using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository : IBaseRepository<UsuarioEntity>
    {
        UsuarioEntity GetByLogin(string Login);
        UsuarioEntity GetBySenha(string Senha);

    }
}
