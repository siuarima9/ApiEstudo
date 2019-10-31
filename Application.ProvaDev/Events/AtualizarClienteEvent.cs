using Application.ProvaDev.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProvaDev.Events
{
    public class AtualizarClienteEvent
    {
        public TipoDeMensagem TipoDeMensagem{ get; set; }
        public string Mensagem { get; set; }

        public AtualizarClienteEvent(TipoDeMensagem tipoDeMensagem, string mensagem)
        {
            TipoDeMensagem = tipoDeMensagem;
            Mensagem = mensagem;
        }
    }
}
