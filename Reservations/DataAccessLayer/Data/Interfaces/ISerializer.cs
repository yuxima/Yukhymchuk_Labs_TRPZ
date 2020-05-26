using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data
{
    interface ISerializer<T>
    {
        void Serialize(T obj, string path);
        T Deserialize(string path);
    }
}
