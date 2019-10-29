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
        private readonly IMapper _mapper;

        public ClienteAppService(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Cadastrar(CadastrarClienteViewModel viewModel)
        {
            var cliente = _mapper.Map<Cliente>(viewModel);

            _repository.Incluir(cliente);
        }

        public ICollection<ClienteViewModel> Listar()
        {
            var clientes = _repository.Listar().ToList();

            return _mapper.Map<ICollection<ClienteViewModel>>(clientes);
        }

        public ClienteComEnderecoViewModel ObterPorId(Guid id)
        {
            var cliente = _repository.ObterPorId(id);

            return _mapper.Map<ClienteComEnderecoViewModel>(cliente);
        }
    }
}
