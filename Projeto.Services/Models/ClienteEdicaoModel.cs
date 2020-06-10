using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class ClienteEdicaoModel
    {
        [Required(ErrorMessage = "Informe o id do cliente.")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente.")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Informe um email válido.")]
        [Required(ErrorMessage = "Informe o email do cliente.")]
        public string Email { get; set; }
    }
}