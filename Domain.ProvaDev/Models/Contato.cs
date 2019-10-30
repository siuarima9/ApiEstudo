using System.Collections.Generic;

namespace Domain.ProvaDev.Models
{
    public partial class Contato
    {

        public int Id { get; set; }

        public string DddTelefone { get; set; }

        public string NumeroTelefone { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
