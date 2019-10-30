using Application.ProvaDev.ViewModels;
using AutoMapper;
using Domain.ProvaDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProvaDev.AutoMapper
{
    public class ViewModelToDomainMapping : Profile
    {
        public ViewModelToDomainMapping()
        {
            CreateMap<CadastrarClienteViewModel, Cliente>()
                .ConstructUsing(c => new Cliente(Guid.NewGuid(), c.IdContato, c.IdEndereco, c.Nome, c.Sobrenome, c.Cpf, c.Rg));
        }   
    }
}
