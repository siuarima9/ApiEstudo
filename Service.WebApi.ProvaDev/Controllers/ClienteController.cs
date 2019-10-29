using Application.ProvaDev.Interfaces;
using Application.ProvaDev.ViewModels;
using System;
using System.Web.Http;

namespace Service.WebApi.ProvaDev.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly IClienteAppService _appService;

        public ClienteController(IClienteAppService appService)
        {
            _appService = appService;
        }

        public IHttpActionResult Get()
        {
            var clientes = _appService.Listar();

            return Ok(clientes);
        }

        public IHttpActionResult Get(Guid id)
        {
            var cliente = _appService.ObterPorId(id);

            return Ok(cliente);
        }

        public IHttpActionResult Post(CadastrarClienteViewModel viewModel)
        {
            try
            {
                _appService.Cadastrar(viewModel);
            } catch(Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok();
        }
    }
}
