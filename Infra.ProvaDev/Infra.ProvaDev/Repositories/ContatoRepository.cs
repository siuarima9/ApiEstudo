using Domain.ProvaDev.Interfaces;
using Domain.ProvaDev.Models;
using Infra.ProvaDev.Context;
using System;

namespace Infra.ProvaDev.Repositories
{
    public class ContatoRepository : Repository<int, Contato>, IContatoRepository
    {
        private ProvaDevContext _context;

        public ContatoRepository(ProvaDevContext context) : base(context)
        {
            _context = context;
        }

    }
}
