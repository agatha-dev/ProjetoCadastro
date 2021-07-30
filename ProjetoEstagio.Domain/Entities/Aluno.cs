
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
        public Guid Id { get; set; }
        public Guid IdTurma { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        #region relacionamento
        public Turma Turma { get; set; }
        #endregion
    }
}
