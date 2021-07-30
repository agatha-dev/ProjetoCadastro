using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstagio.Domain.Entities
{
    public class Turma
    {
        [Key]
        public Guid Id { get; set; }
        public string NomeCurso { get; set; }
        public string NomeProfessor { get; set; }
        public string Ementa { get; set; }

        #region relacionamento
        public ICollection<Aluno> Alunos { get; set; }
        #endregion

    }
}
