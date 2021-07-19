using Projeto.Application.Models;
using Projeto.Domain;
using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface ITurmaApplicationService
    {
        void Insert(TurmaCadastroModel model);
        void Update(TurmaEdicaoModel model);
        void Delete(Guid id);
        List<Turma> GetAll();
        Turma GetById(Guid id);
    }
}