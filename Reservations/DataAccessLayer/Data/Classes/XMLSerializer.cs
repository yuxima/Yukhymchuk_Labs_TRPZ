using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Configuration;
using System.Text;

namespace Reservations.Data
{
    class XMLSerializer<T>:ISerializer<T>
    {
        DataContractSerializer xmlSerializer;
        
        public XMLSerializer(Type type)
        {
            xmlSerializer = new DataContractSerializer(type);
        }
        public T Deserialize(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                return (T)xmlSerializer.ReadObject(stream);
            }
        }

        public void Serialize(T obj, string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.WriteObject(stream, obj);
            }
        }
    }
}
