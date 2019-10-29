using System;

namespace Application.ProvaDev.ViewModels
{
    public class ClienteViewModel
    {
        public Guid Id { get; set; }

        public string NomeCompleto { get; set; }

        public string Cpf { get; set; }

        public string Rg { get; set; }

        public ContatoViewModel ContatoDoCliente { get; set; }
    }
}
