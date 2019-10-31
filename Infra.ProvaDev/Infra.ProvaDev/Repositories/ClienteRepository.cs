using Domain.ProvaDev.Interfaces;
using Domain.ProvaDev.Models;
using Infra.ProvaDev.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infra.ProvaDev.Repositories
{
    public class ClienteRepository : Repository<Guid, Cliente>, IClienteRepository
    {
        private readonly ProvaDevContext _context;

        public ClienteRepository(ProvaDevContext context) : base(context)
        {
            _context = context;
        }

        public ICollection<Cliente> ListarClientes()
        {
            var clientes = _context.Set<Cliente>().Include(x => x.Contato).ToList();

            return clientes;
        }

        public Cliente ObterClientePorId(Guid id)
        {
            var cliente = _context.Set<Cliente>()
                            .Include(x => x.Endereco).ThenInclude(x => x.UnidadeFederativa)
                            .Where(x => x.Id == id)
                            .FirstOrDefault();

            return cliente;
        }

        public Cliente ObterPorFiltro(Expression<Func<Cliente, bool>> predicate)
        {
            var cliente = _context.Set<Cliente>().Where(predicate).FirstOrDefault();

            return cliente;
        }
    }
}
