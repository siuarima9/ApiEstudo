using System.Collections.Generic;

namespace Domain.ProvaDev.Models
{
    public partial class UnidadeFederativa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sigla { get; set; }

        public virtual ICollection<Endereco> Endereco { get; set; }
    }
}
