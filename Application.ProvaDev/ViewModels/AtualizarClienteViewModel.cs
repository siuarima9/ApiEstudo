using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProvaDev.ViewModels
{
    public class AtualizarClienteViewModel
    {
        [Required]
        public Guid Id { get; set; }
        public int? IdContato { get; set; }
        public int? IdEndereco { get; set; }
    }
}
