using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using DataAccessLayer.Abstract;

namespace DataAccessLayer.Implementation.Data.Classes
{
    public class DataController<T>:IDataController<T>
    {
        ISerializer<T> serializer;
        public DataController(ISerializer<T> serializer)
        {
            this.serializer = serializer;
        }
        public T GetInformation()
        {
            return serializer.Deserialize(ConfigurationManager.AppSettings["PathToFile"]);
        }

        public void SetInformation(T obj)
        {
            serializer.Serialize(obj, ConfigurationManager.AppSettings["PathToFile"]);
        }
    }
}
