using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ProvaDev.Models
{
    [Table("Cliente")]
    public partial class Cliente
    {
        public Guid id { get; set; }

        public int idContato { get; set; }

        public int idEndereco { get; set; }

        [Required]
        [StringLength(50)]
        public string nome { get; set; }

        [Required]
        [StringLength(150)]
        public string sobrenome { get; set; }

        [Required]
        [StringLength(11)]
        public string cpf { get; set; }

        [Required]
        [StringLength(15)]
        public string rg { get; set; }

        public virtual Contato Contato { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}
