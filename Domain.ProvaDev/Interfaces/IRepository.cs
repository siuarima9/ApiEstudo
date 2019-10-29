using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ProvaDev.Interfaces
{
    public interface IRepository<TKey, TEntity>
        where TKey: struct
        where TEntity: class
    {
        void Incluir(TEntity obj);
        IQueryable<TEntity> Listar();
        TEntity ObterPorId(TKey id);
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        int SaveChanges();
    }
}
