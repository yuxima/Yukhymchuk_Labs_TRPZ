using Microsoft.EntityFrameworkCore;
using Reservations.Data.Entities;
using Reservations.Data.Repositories.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    class ReservationRepository:Repository<ReservationEntity, int>,IReservationRepository
    {
        public ReservationRepository(ApplicationContext context)
            :base(context)
        {
            
        }
    }
}
