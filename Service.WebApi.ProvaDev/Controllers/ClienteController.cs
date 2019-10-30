using Application.ProvaDev.Interfaces;
using Application.ProvaDev.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Service.WebApi.ProvaDev.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly IClienteAppService _appService;

        //public ClienteController() { }

        public ClienteController(IClienteAppService appService)
        {
            _appService = appService;
        }

        public ICollection<ClienteViewModel> Get()
        {
            var clientes = _appService.Listar();

            return clientes;
        }

        public ClienteComEnderecoViewModel Get(Guid id)
        {
            var cliente = _appService.ObterPorId(id);

            return cliente;
        }

        public IHttpActionResult Post([FromBody] CadastrarClienteViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Erro, campos não preenchidos corretamente");

            try
            {
                return Ok(_appService.Cadastrar(viewModel));
            } catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public IHttpActionResult Put([FromBody] AtualizarClienteViewModel viewModel)
        {
            try
            {
                _appService.Atualizar(viewModel);
                return Ok("Cliente atualizado com sucesso");
            }catch(Exception e)
            {
                return BadRequest("Não foi possível atualizar o cliente. ERRO: \n" + e.Message);
            }
        }

        //public IHttpActionResult Post(CadastrarClienteViewModel viewModel)
        //{
        //    try
        //    {
        //        _appService.Cadastrar(viewModel);
        //    } catch(Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }

        //    return Ok();
        //}
    }
}
