using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
    public class TurmaCadastroModel
    {
        [MinLength(3, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome da Turma.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de inicio da Turma.")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de termino da Turma.")]
        public DateTime DataTermino { get; set; }

        [MinLength(3, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(400, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a ementa da Turma.")]
        public string Ementa { get; set; }

        [Required(ErrorMessage = "Por favor, informe o id do Professor.")]
        public int IdProfessor { get; set; }
    }
}