using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ISerializer<T>
    {
        void Serialize(T obj, string path);
        T Deserialize(string path);
    }
}
