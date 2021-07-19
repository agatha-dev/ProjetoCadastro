using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain;
using Projeto.Domain.Contracts.Services;
using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
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
            var turma = new Turma();

            turma.IdTurma = Guid.NewGuid();
            turma.IdAluno = Guid.NewGuid();
            turma.Curso = model.Curso;

            turmaDomainService.Insert(turma);
        }

        public void Update(TurmaEdicaoModel model)
        {
            var turma = new Turma();

            turma.IdTurma = model.IdTurma;
            turma.Curso = model.Curso;

            turmaDomainService.Update(turma);
        }
    }
}
