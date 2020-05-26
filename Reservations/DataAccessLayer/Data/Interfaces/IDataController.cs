using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Interfaces
{
    public interface IDataController<T>
    {
        void SetInformation(T obj);
        T GetInformation();
    }
}
