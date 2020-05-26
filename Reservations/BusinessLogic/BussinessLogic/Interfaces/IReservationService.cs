using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.BussinessLogic.Interfaces
{
    interface IReservationService
    {
        void CreateReservation(int Idshop, int Idproduct, int numberOfProducts);
    }
}
