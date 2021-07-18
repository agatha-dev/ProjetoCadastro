using Projeto.Application.Models;
using Projeto.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IAlunoApplicationService
    {
        void Insert(AlunoCadastroModel model);
        void Update(AlunoEdicaoModel model);
        void Delete(int id);
        List<Aluno> GetAll();
        Aluno GetById(int id);
    }
}