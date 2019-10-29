using Domain.ProvaDev.Interfaces;
using Domain.ProvaDev.Models;
using System.Data.Entity;
using System.Linq;

namespace Infra.ProvaDev.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly Context.Context _context;

        public ClienteRepository(Context.Context context) : base(context)
        {
            _context = context;
        }

        public new IQueryable<Cliente> Listar()
        {
            var clientes = _context.Clientes
                            .Include(x => x.Contato);

            return clientes;
        }
    }
}
