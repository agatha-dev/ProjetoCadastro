using Projeto.Application.Models;
using Projeto.Domain;
using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IAlunoApplicationService
    {
        void Insert(AlunoCadastroModel model);
        void Update(AlunoEdicaoModel model);
        void Delete(Guid id);
        List<Aluno> GetAll();
        Aluno GetById(Guid id);
    }
}