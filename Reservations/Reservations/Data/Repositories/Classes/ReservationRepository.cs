using Microsoft.EntityFrameworkCore;
using Reservations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Repositories
{
    class ReservationRepository:IReservationRepository
    {
        private DbSet<ReservationEntity> _context;
        public ReservationRepository(ApplicationContext context)
        {
            _context = context.Set<ReservationEntity>();
        }
        public void DeleteById(int Id)
        {
            ReservationEntity reservation = _context.Find(Id);
            _context.Remove(reservation);
        }

        public IEnumerable<ReservationEntity> GetAll()
        {
            return _context;
        }

        public ReservationEntity GetById(int Id)
        {
            return _context.Find(Id);
        }

        public void Insert(ReservationEntity entity)
        {
            _context.Add(entity);
        }

        public void Update(ReservationEntity entity)
        {
            _context.Update(entity);
        }
    }
}
