using Reservations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    interface IReservationRepository: IRepository<ReservationEntity, int>
    {
        IEnumerable<ReservationEntity> GetAll();
        void Insert(ReservationEntity model);
        void Update(ReservationEntity model);
        ReservationEntity GetById(int Id);
        void DeleteById(int Id);
    }
}
