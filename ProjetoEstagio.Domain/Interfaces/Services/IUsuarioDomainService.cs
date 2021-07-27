using Projeto.Domain.Contracts.Services;
using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Domain.Interfaces.Services
{
    public  interface IUsuarioDomainService : IBaseDomainService<Usuario>
    {
        Usuario GetByLoginAndSenha(string Login, string Senha);
        Usuario GetByLogin(string Login);
    }
}
