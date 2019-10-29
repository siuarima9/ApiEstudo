using Domain.ProvaDev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ProvaDev.Repositories
{
    public class Repository<TEntity> : IRepository<Guid, TEntity>
        where TEntity : class
    {
        private readonly Context.Context _context;

        public Repository(Context.Context context)
        {
            _context = context;
        }

        public void Atualizar(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Incluir(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<TEntity> Listar()
        {
            return _context.Set<TEntity>();
        }

        public TEntity ObterPorId(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remover(TEntity obj)
        {
            throw new NotImplementedException();
        }

    }
}
