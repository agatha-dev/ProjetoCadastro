using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Services
{
    public interface IAlunoDomainService : IBaseDomainService<Aluno>
    {
        void Update(Aluno obj);
    }
}
