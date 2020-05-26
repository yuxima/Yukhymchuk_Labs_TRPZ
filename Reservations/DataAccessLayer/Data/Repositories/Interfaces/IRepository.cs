using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Repositories.Interfaces
{
    public interface IRepository<TEntity,TKey>
    {
        IEnumerable<TEntity> GetAll();
        void Insert(TEntity model);
        void Update(TEntity model);
        TEntity GetById(TKey Id);
        void DeleteById(TKey Id);
    }
}
