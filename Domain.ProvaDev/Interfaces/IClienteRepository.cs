using Domain.ProvaDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ProvaDev.Interfaces
{
    public interface IClienteRepository : IRepository<Guid, Cliente>
    {
        ICollection<Cliente> ListarClientes();
        Cliente ObterClientePorId(Guid id);

        Cliente ObterPorFiltro(Expression<Func<Cliente, bool>> predicate);
    }
}
