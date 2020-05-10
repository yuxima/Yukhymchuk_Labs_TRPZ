using Microsoft.EntityFrameworkCore;
using Reservations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    class ProductRepository:IProductRepository
    {
        private DbSet<ProductEntity> _context;
        public ProductRepository(ApplicationContext context)
        {
            _context = context.Set<ProductEntity>();
        }
        public void DeleteById(int Id)
        {
            ProductEntity product = _context.Find(Id);
            _context.Remove(product);
        }

        public IEnumerable<ProductEntity> GetAll()
        {
            return _context;
        }

        public ProductEntity GetById(int Id)
        {
            return _context.Find(Id);
        }

        public void Insert(ProductEntity entity)
        {
            _context.Add(entity);
        }

        public void Update(ProductEntity entity)
        {
            _context.Update(entity);
        }
    }
}
