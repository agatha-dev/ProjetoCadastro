using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using ProjetoEstagio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class AlunoDomainService : BaseDomainService<Aluno>, IAlunoDomainService
    {
        private readonly IAlunoRepository alunoRepository;

        public AlunoDomainService(IAlunoRepository alunoRepository) : base(alunoRepository)
        {
            this.alunoRepository = alunoRepository;
        }

        public override void Insert(Aluno obj)
        {
            if (alunoRepository.GetEmail(obj.Email) != null)
            {
                throw new Exception($"O email {obj.Email} já encontra - se cadastrado no sistema.");
            }
            else
            {
                alunoRepository.Insert(obj);
            }
        }

        public override void Update(Aluno obj)
        {
            var registro = alunoRepository.GetById(obj.Id);

            if (registro != null)
            {
                if (!registro.Email.Equals(obj.Email))
                {
                    alunoRepository.Update(obj);
                }
                else
                {
                    throw new Exception("Erro. Não é permitido alterar o Email do Aluno.");
                }
            }
            else
            {
                throw new Exception("Aluno não encontrado.");
            }
        }
    }
}
