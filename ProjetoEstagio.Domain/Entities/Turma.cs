using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Domain.Entities
{
    public class Turma
    {
        public Guid IdTurma { get; set; }
        public Guid IdAluno { get; set; }
        public string Curso { get; set; }

        #region relacionamento
        //1 para muitos
        public List<Aluno> Alunos { get; set; }
        #endregion

    }
}
