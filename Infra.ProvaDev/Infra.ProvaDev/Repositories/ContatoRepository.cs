using Domain.ProvaDev.Interfaces;
using Domain.ProvaDev.Models;
using Infra.ProvaDev.Context;
using System;

namespace Infra.ProvaDev.Repositories
{
    public class ContatoRepository : Repository<Contato>, IContatoRepository
    {
        private ProvaDevContext _context;

        public ContatoRepository(ProvaDevContext context) : base(context)
        {
            _context = context;
        }

        public Contato ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
