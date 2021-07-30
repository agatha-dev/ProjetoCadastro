using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain;
using Projeto.Domain.Contracts.Services;
using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Application.Services
{
    public class TurmaApplicationService : ITurmaApplicationService
    {
        private readonly ITurmaDomainService turmaDomainService;

        public TurmaApplicationService(ITurmaDomainService turmaDomainService)
        {
            this.turmaDomainService = turmaDomainService;
        }

        public void Delete(Guid id)
        {
            var turma = turmaDomainService.GetById(id);
            turmaDomainService.Delete(turma);
        }

        public List<Turma> GetAll()
        {
            return turmaDomainService.GetAll();
        }

        public Turma GetById(Guid id)
        {
            return turmaDomainService.GetById(id);
        }

        public void Insert(TurmaCadastroModel model)
        {
            var turma = new Turma
            {
                NomeCurso = model.NomeCurso,
                NomeProfessor = model.NomeProfessor,
                Ementa = model.Ementa
            };

            turmaDomainService.Insert(turma);
        }

        public void Update(TurmaEdicaoModel model)
        {
            var turma = new Turma
            {
                NomeCurso = model.NomeCurso,
                NomeProfessor = model.NomeProfessor,
                Ementa = model.Ementa
            };

            turmaDomainService.Update(turma);
        }
    }
}
