using Microsoft.EntityFrameworkCore;
using Reservations.Data.Entities;
using Reservations.Data.Repositories.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    class ProductRepository:Repository<ProductEntity, int>, IProductRepository
    {
        public ProductRepository(ApplicationContext context)
            :base(context)
        {
        }
    }
}
