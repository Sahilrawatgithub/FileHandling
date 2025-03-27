using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Filehandling
{
    internal class JsonFileHandling
    {
        public static void Create(string path) 
        {
            FileStream fs=File.Create(path);
            fs.Close();
        }

        public static void Override(string path, Person contents)
        {            
            string jsonData=JsonSerializer.Serialize(contents);
            File.WriteAllText(path, jsonData);
        }

        public static void Append(string path,Person contents)
        {
            
        }
    }
}
