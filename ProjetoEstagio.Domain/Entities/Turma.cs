using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Domain.Entities
{
    class Turma
    {
        public Guid IdTurma { get; set; }
        public string Curso { get; set; }
        //1 para muitos
        public List<Aluno> Alunos { get; set; }

    }
}
