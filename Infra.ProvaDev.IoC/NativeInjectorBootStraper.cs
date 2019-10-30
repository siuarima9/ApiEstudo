using Application.ProvaDev.AutoMapper;
using Application.ProvaDev.Interfaces;
using Application.ProvaDev.Service;
using AutoMapper;
using Domain.ProvaDev.Interfaces;
using Infra.ProvaDev.Context;
using Infra.ProvaDev.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Ninject;
using Ninject.Modules;

namespace Infra.ProvaDev.IoC
{
    public class NativeInjectorBootStraper 
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<ProvaDevContext>().ToSelf();

            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<IContatoRepository>().To<ContatoRepository>();
            kernel.Bind<IEnderecoRepository>().To<EnderecoRepository>();

            kernel.Bind<IClienteAppService>().To<ClienteAppService>();
        }
    }
}
