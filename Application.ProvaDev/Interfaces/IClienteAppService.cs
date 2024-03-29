﻿using Application.ProvaDev.Events;
using Application.ProvaDev.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProvaDev.Interfaces
{
    public interface IClienteAppService
    {
        ICollection<ClienteViewModel> Listar();

        ClienteComEnderecoViewModel ObterPorId(Guid id);

        ClienteViewModel Cadastrar(CadastrarClienteViewModel viewModel);

        AtualizarClienteEvent Atualizar(AtualizarClienteViewModel viewModel);
    }
}
