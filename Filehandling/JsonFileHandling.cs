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
            List<Person> obj = new(){ contents };
            string jsonData=JsonSerializer.Serialize(obj);
            File.WriteAllText(path, jsonData);
        }

        public static void Append(string path,Person contents)
        {
            List<Person> obj = new List<Person>();
            obj.Add(contents);

            string json=File.ReadAllText(path);

            obj = JsonSerializer.Deserialize<List<Person>>(json);

            obj.Add(contents);

            string updatedjson=JsonSerializer.Serialize(obj);

            File.WriteAllText(path, updatedjson);


        }
    }
}


//delegates and events
//custom annotations,custom reflections