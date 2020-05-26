using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data.Entities
{
    class ReservationEntity : IEntity<int>
    {
        public int Id { get; set; }
        public ProductEntity Product { get; set; }
        public int ProductId { get; set; }
        public int Number { get; set; }
        public DateTime DateOfReservation { get; set; }
        public DateTime EndTimeOfReservation { get; set; }
        public ShopEntity Shop { get; set; }
        public int ShopId { get; set; }
        public int NumberOfReservedProduct { get; set; }
    }
}
