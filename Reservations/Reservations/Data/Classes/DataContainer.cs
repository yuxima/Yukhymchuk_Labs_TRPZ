using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data
{
    class DataContainer<T>:IDataContainer<T>
    {
        IDataController<T> dataController;
        public IDataController<T> GetData()
        {
            dataController = new DataController<T>(new XMLSerializer<T>(typeof(T)));
            return dataController;
        }
    }
}
