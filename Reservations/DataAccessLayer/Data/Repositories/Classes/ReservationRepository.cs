using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Data.Classes;
using DataAccessLayer.Data.Entities;
using DataAccessLayer.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Repositories.Classes
{
    class ReservationRepository:Repository<ReservationEntity, int>,IReservationRepository
    {
        public ReservationRepository(ApplicationContext context)
            :base(context)
        {
            
        }
    }
}
