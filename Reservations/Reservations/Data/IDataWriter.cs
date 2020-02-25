using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Data
{
    interface IDataWriter
    {
        void WriteData(string path, object obj) { }
        
    }
}
