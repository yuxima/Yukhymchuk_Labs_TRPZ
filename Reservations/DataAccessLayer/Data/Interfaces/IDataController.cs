using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data
{
    interface IDataController<T>
    {
        void SetInformation(T obj);
        T GetInformation();
    }
}
