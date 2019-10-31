using Application.ProvaDev.Enums;
using Application.ProvaDev.Events;
using Application.ProvaDev.Interfaces;
using Application.ProvaDev.ViewModels;
using AutoMapper;
using Domain.ProvaDev.Interfaces;
using Domain.ProvaDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.ProvaDev.Service
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteRepository _repository;
        //private readonly IContatoRepository _contatoRepository;
        //private readonly IEnderecoRepository _enderecoRepository;

        public ClienteAppService(IClienteRepository repository/*, IContatoRepository contatoRepository, IEnderecoRepository enderecoRepository*/)
        {
            _repository = repository;
            //_contatoRepository = contatoRepository;
            //_enderecoRepository = enderecoRepository;
        }

        public AtualizarClienteEvent Atualizar(AtualizarClienteViewModel viewModel)
        {
            var cliente = _repository.ObterPorId(viewModel.Id);

            if(!(viewModel.IdContato.HasValue && viewModel.IdEndereco.HasValue))
                return new AtualizarClienteEvent(TipoDeMensagem.Falha, "Não foi informado dados para atualização");

            if (cliente == null)
                return new AtualizarClienteEvent(TipoDeMensagem.Falha, "CLIENTE NÃO ENCONTRADO");

            cliente.AlterarContato(viewModel.IdContato.Value);
            cliente.AlterarEndereco(viewModel.IdEndereco.Value);

            _repository.Atualizar(cliente);

            return new AtualizarClienteEvent(TipoDeMensagem.Sucesso, "Cliente atualizado com sucesso");
        }

        public ClienteViewModel Cadastrar(CadastrarClienteViewModel viewModel)
        {
            var cliente = _repository.ObterPorFiltro(x => x.Cpf == viewModel.Cpf);

            if (cliente != null) throw new Exception("Cliente ja existe. Nome: " + cliente.Nome);

            cliente = Mapper.Map<Cliente>(viewModel);

            _repository.Incluir(cliente);

            return Mapper.Map<ClienteViewModel>(cliente);
        }

        public ICollection<ClienteViewModel> Listar()
        {
            var clientes = _repository.ListarClientes();

            return Mapper.Map<ICollection<ClienteViewModel>>(clientes);
        }

        public ClienteComEnderecoViewModel ObterPorId(Guid id)
        {
            var cliente = _repository.ObterClientePorId(id);

            return Mapper.Map<ClienteComEnderecoViewModel>(cliente);
        }
    }
}
