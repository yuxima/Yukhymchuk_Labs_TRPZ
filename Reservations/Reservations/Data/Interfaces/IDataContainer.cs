using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data
{
    interface IDataContainer<T>
    {
        IDataController<T> GetData();
    }
}
