
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Domain.Entities
{
    public class Aluno 
    {
        [Key]
        public Guid IdAlunos { get; set; }
        public string Cpf { get; set; }
        public string nome { get; set; }
        public Guid  IdMatricula { get; set; }
        public Guid  IdTurma { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        #region relacionamento
        //1 para 1
        public Turma Turma { get; set; }

        #endregion
    }
}
