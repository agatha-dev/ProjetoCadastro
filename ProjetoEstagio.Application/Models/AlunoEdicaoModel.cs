using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
    public class AlunoEdicaoModel
    {
        [Required(ErrorMessage = "Por favor, informe o id do Aluno.")]
        public Guid IdAluno { get; set; }

        [MinLength(3, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do Aluno.")]
        public string Nome { get; set; }

        [MaxLength(11, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o CPF do Aluno.")]
        public string Cpf { get; set; }

        [MinLength(3, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o Endereço do Aluno.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Por favor, informe o email do cliente.")]
        [EmailAddress(ErrorMessage = "Por favor, informe um email válido.")]
        public string Email { get; set; }

    }
}