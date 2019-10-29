using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.ProvaDev.Models
{

    [Table("Endereco")]
    public partial class Endereco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Endereco()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int id { get; set; }

        public int idUnidadeFederativa { get; set; }

        [Required]
        [StringLength(8)]
        public string cep { get; set; }

        [Required]
        [StringLength(100)]
        public string cidade { get; set; }

        [Required]
        [StringLength(100)]
        public string logradouro { get; set; }

        [StringLength(100)]
        public string bairro { get; set; }

        [Required]
        [StringLength(5)]
        public string numero { get; set; }

        [StringLength(200)]
        public string complemento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }

        public virtual UnidadeFederativa UnidadeFederativa { get; set; }
    }
}
