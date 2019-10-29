using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ProvaDev.Models
{
    [Table("Usuario")]
    public partial class Usuario
    {
        public Guid id { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }

        [Required]
        [StringLength(80)]
        public string senha { get; set; }

        public bool ativo { get; set; }
    }
}
