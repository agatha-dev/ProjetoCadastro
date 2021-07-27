using Projeto.Application.Models;
using ProjetoEstagio.Domain.Entities;

namespace Projeto.Application.Contracts
{
    public interface IUsuarioApplicationService
    {
        void Insert(UsuarioCadastroModel model);
        Usuario GetByLogin(string login);
        Usuario GetByLoginAndSenha(UsuarioAutenticacaoModel model);
    }
}