using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ProvaDev.Models
{
    public partial class Usuario
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public bool Ativo { get; set; }
    }
}
