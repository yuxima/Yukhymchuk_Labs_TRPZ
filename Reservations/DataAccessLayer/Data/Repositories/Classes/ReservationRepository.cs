using Microsoft.EntityFrameworkCore;
using Entities;
using DataAccessLayer.Implementation.Data.Classes;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Implementation.Data.Repositories.Classes
{
    class ReservationRepository:Repository<ReservationEntity, int>,IReservationRepository
    {
        public ReservationRepository(ApplicationContext context)
            :base(context)
        {
            
        }
    }
}
