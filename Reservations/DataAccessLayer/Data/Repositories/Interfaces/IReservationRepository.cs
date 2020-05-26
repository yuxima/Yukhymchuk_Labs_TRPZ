using DataAccessLayer.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Repositories.Interfaces
{
    public interface IReservationRepository: IRepository<ReservationEntity, int>
    {
        
    }
}
