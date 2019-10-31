using Application.ProvaDev.Interfaces;
using Application.ProvaDev.Service;
using Domain.ProvaDev.Interfaces;
using Infra.ProvaDev.Context;
using Infra.ProvaDev.Repositories;
using Ninject;

namespace Infra.ProvaDev.IoC
{
    public class NativeInjector 
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
