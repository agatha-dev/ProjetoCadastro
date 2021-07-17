
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Domain.Entities
{
    class Aluno 
    {
        public Guid IdAluno { get; set; }
        public string Cpf { get; set; }
        public string nome { get; set; }
        public Guid  IdMatricula { get; set; }
        public string Endeco { get; set; }
        public string Email { get; set; }
        //1 para 1
        public Turma Turma { get; set; }


    }
}
