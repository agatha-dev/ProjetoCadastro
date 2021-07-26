using Projeto.Domain.Contracts.Services;
using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Domain.Interfaces.Services
{
    public  interface IUsuarioDomainService : IBaseDomainService<UsuarioEntity>
    {
        UsuarioEntity GetByLoginAndSenha(string Login, string Senha);
        UsuarioEntity GetByLogin(string Login);
    }
}
