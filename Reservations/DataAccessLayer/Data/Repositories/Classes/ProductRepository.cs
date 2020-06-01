using Entities;
using DataAccessLayer.Implementation.Data.Classes;
using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Implementation.Data.Repositories.Classes
{
    class ProductRepository:Repository<ProductEntity, int>, IProductRepository
    {
        public ProductRepository(ApplicationContext context)
            :base(context)
        {
        }
    }
}
