using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    interface IRepository<TEntity,TKey>
    {
        IEnumerable<TEntity> GetAll();
        void Insert(TEntity model);
        void Update(TEntity model);
        TEntity GetById(TKey Id);
        void DeleteById(TKey Id);
    }
}
