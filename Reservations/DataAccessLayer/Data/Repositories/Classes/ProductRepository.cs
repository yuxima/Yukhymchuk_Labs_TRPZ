using DataAccessLayer.Data.Classes;
using DataAccessLayer.Data.Entities;
using DataAccessLayer.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Repositories.Classes
{
    class ProductRepository:Repository<ProductEntity, int>, IProductRepository
    {
        public ProductRepository(ApplicationContext context)
            :base(context)
        {
        }
    }
}
