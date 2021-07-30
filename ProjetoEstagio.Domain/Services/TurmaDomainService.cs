using Projeto.Domain.Contracts.Services;
using ProjetoEstagio.Domain.Entities;
using ProjetoEstagio.Domain.Interfaces.Repositors;

namespace Projeto.Domain.Services
{
    public class TurmaDomainService : BaseDomainService<Turma>, ITurmaDomainService
    {
        private readonly ITurmaRepository turmaRepository;

        public TurmaDomainService(ITurmaRepository turmaRepository) : base(turmaRepository)
        {
            this.turmaRepository = turmaRepository;
        }

        public override void Insert(Turma obj)
        {
            base.Insert(obj);
        }
    }
}