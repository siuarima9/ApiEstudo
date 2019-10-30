using Application.ProvaDev.ViewModels;
using AutoMapper;
using Domain.ProvaDev.Models;

namespace Application.ProvaDev.AutoMapper
{
    public class DomainToViewModelMapping : Profile
    {
        public DomainToViewModelMapping()
        {
            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(x => x.NomeCompleto, opt => opt.MapFrom(src => src.Nome + " " + src.Sobrenome))
                .ForMember(x => x.ContatoDoCliente, opt => opt.MapFrom(src => src.Contato));

            CreateMap<Cliente, ClienteComEnderecoViewModel>();

            CreateMap<Endereco, EnderecoViewModel>();
        }
    }
}
