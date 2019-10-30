using System.Collections.Generic;

namespace Domain.ProvaDev.Models
{
    public partial class Endereco
    {
        public int Id { get; set; }

        public int IdUnidadeFederativa { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }

        public virtual UnidadeFederativa UnidadeFederativa { get; set; }
    }
}
