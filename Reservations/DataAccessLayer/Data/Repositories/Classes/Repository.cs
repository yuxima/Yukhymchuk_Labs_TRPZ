using DataAccessLayer.Data.Classes;
using DataAccessLayer.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Repositories.Classes
{
    class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity:class
    {
        protected readonly DbSet<TEntity> _context;
        public Repository(ApplicationContext context)
        {
            _context = context.Set<TEntity>();
        }
        public void DeleteById(TKey Id)
        {
            TEntity entity = _context.Find(Id);
            _context.Remove(entity);
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.AsNoTracking();
        }

        public TEntity GetById(TKey Id)
        {
            return _context.Find(Id);
        }

        public void Insert(TEntity entity)
        {
            _context.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
        }
    }
}
