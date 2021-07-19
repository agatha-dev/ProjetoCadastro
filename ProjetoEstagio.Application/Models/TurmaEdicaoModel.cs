using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
    public class TurmaEdicaoModel
    {
        [Required(ErrorMessage = "Por favor, informe o id da Turma.")]
        public Guid IdTurma { get; set; }

        [MinLength(3, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome da Turma.")]
        public string Curso { get; set; }

    }
}