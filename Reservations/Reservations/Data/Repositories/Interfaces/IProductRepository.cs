using Reservations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    interface IProductRepository:IRepository<ProductEntity, int>
    {
        IEnumerable<ProductEntity> GetAll();
        void Insert(ProductEntity model);
        void Update(ProductEntity model);
        ProductEntity GetById(int Id);
        void DeleteById(int Id);
    }
}
