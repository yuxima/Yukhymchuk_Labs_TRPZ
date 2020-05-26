using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IReservationService
    {
        public void CreateReservation(int Idshop, int Idproduct, int numberOfProducts);
    }
}
