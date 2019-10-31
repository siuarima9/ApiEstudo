using Application.ProvaDev.Enums;
using Application.ProvaDev.Service;
using Application.ProvaDev.ViewModels;
using Domain.ProvaDev.Models;
using Infra.ProvaDev.Repositories;
using Moq;
using System;
using Xunit;

namespace Test.ProvaDev.ClienteTest
{
    public class ClienteTest
    {
        private Mock<ClienteRepository> _repository;
        private ClienteAppService _appService;

        public ClienteTest()
        {
            _repository = new Mock<ClienteRepository>(null);
            _appService = new ClienteAppService(_repository.Object);
        }

        [Fact]
        public void ClienteTestSucesso()
        {
            var viewModelFake = ViewModelFaKe(Guid.NewGuid(), 1, 1);
            var cliente = new Cliente(viewModelFake.Id, 0, 0, "alan", "guerra", "45645645678", "489456");

            _repository.Setup(x => x.ObterPorId(viewModelFake.Id)).Returns(cliente);

            _appService.Atualizar(viewModelFake);

            _repository.Verify(x => x.Atualizar(It.IsAny<Cliente>()), Times.Once());
        }

        [Fact]
        public void ClienteTestFalhaViewModel()
        {
            var viewModelFake = ViewModelFaKe(Guid.NewGuid(), null, null);
            var cliente = new Cliente(viewModelFake.Id, 0, 0, "alan", "guerra", "45645645678", "489456");

            _repository.Setup(x => x.ObterPorId(viewModelFake.Id)).Returns(cliente);

            var resultEvent = _appService.Atualizar(viewModelFake);

            _repository.Verify(x => x.Atualizar(It.IsAny<Cliente>()), Times.Never());
            Assert.Equal("Não foi informado dados para atualização", resultEvent.Mensagem);
            Assert.Equal(TipoDeMensagem.Falha, resultEvent.TipoDeMensagem);
        }

        [Fact]
        public void ClienteTestFalhaClienteNaoEncontrado()
        {
            var viewModelFake = ViewModelFaKe(Guid.NewGuid(), 1, 1);
            var cliente = new Cliente(viewModelFake.Id, 0, 0, "alan", "guerra", "45645645678", "489456");

            _repository.Setup(x => x.ObterPorId(Guid.NewGuid())).Returns(cliente);

            var resultEvent = _appService.Atualizar(viewModelFake);

            _repository.Verify(x => x.Atualizar(It.IsAny<Cliente>()), Times.Never());
            Assert.Equal("CLIENTE NÃO ENCONTRADO", resultEvent.Mensagem);
            Assert.Equal(TipoDeMensagem.Falha, resultEvent.TipoDeMensagem);
        }

        private AtualizarClienteViewModel ViewModelFaKe(Guid id, int? idContato, int? idEndereco)
        {
            return new AtualizarClienteViewModel
            {
                Id = id,
                IdContato = idContato,
                IdEndereco = idEndereco
            };
        }
    }
}
