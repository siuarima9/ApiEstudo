using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Application.ProvaDev.ViewModels
{
    public class CadastrarClienteViewModel
    {
        [Required(ErrorMessage = "Contato é obrigatorio")]
        public int IdContato { get; set; }
        [Required(ErrorMessage = "IdEndereco é obrigatorio")]
        public int IdEndereco { get; set; }
        [Required(ErrorMessage = "Nome é obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Sobrenome é obrigatorio")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Cpf é obrigatorio")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Rg é obrigatorio")]
        public string Rg { get; set; }
    }
}
