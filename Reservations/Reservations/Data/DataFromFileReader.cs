using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Reservations.Data
{
    class DataFromFileReader:IDataReader
    {
        private static List<string> strings;
        public DataFromFileReader()
        {
            strings = new List<string>();
        }
        private class FileExeption : Exception
        {
            public FileExeption(string message)
                : base(message) { }
        }
        
        void IDataReader.ReadData(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    while (!sr.EndOfStream) strings.Add(sr.ReadLine());
                }
            }
            catch (Exception ex)
            {
                throw new FileExeption(ex.Message);
            }
        }
    }
    }
}
