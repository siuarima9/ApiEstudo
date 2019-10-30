using Domain.ProvaDev.Interfaces;
using Domain.ProvaDev.Models;
using Infra.ProvaDev.Context;
using System;

namespace Infra.ProvaDev.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        private ProvaDevContext _context;

        public EnderecoRepository(ProvaDevContext context): base(context)
        {
            _context = context;
        }
        public Endereco ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
