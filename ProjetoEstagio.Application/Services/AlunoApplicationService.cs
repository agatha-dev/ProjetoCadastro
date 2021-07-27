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
    public class AlunoApplicationService : IAlunoApplicationService
    {
        private readonly IAlunoDomainService alunoDomainService;

        public AlunoApplicationService(IAlunoDomainService alunoDomainService)
        {
            this.alunoDomainService = alunoDomainService;
        }

        public void Delete(Guid id)
        {
            var aluno = alunoDomainService.GetById(id);
            alunoDomainService.Delete(aluno);
        }

        public List<Aluno> GetAll()
        {
            return alunoDomainService.GetAll();
        }

        public Aluno GetById(Guid id)
        {
            return alunoDomainService.GetById(id);
        }

        public void Insert(AlunoCadastroModel model)
        {
            var aluno = new Aluno();

            aluno.IdAlunos = Guid.NewGuid();
            aluno.IdMatricula = Guid.NewGuid();
            aluno.IdTurma = Guid.NewGuid();
            aluno.Cpf = model.Cpf;
            aluno.nome = model.Nome;
            aluno.Email = model.Email;
            aluno.Endereco = model.Endereco;
            
            alunoDomainService.Insert(aluno);
        }

        public void Update(AlunoEdicaoModel model)
        {
            var aluno = new Aluno();

            aluno.IdAlunos = model.IdAluno;
            aluno.nome = model.Nome;
            aluno.Email = model.Email;

            alunoDomainService.Update(aluno);
        }
    }
}