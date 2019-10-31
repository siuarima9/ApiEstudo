using Domain.ProvaDev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ProvaDev.Repositories
{
    public class Repository<TKey, TEntity> : IRepository<TKey, TEntity>
        where TKey : struct
        where TEntity : class
    {
        private readonly Context.ProvaDevContext _context;

        public Repository(Context.ProvaDevContext context)
        {
            _context = context;
        }

        public virtual void Atualizar(TEntity obj)
        {
            _context.Set<TEntity>().Update(obj);
            _context.SaveChanges();
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

        public virtual TEntity ObterPorId(TKey id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remover(TEntity obj)
        {
            throw new NotImplementedException();
        }

    }
}
