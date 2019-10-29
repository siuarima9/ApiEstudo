﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProvaDev.ViewModels
{
    public class EnderecoViewModel
    {
        public int Id { get; set; }

        public int IdUnidadeFederativa { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public UnidadeFederativaViewModel UF { get; set; }
    }
}
