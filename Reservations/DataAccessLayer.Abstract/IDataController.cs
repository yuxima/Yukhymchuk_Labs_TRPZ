using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IDataController<T>
    {
        void SetInformation(T obj);
        T GetInformation();
    }
}
