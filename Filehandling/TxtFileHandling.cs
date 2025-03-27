using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filehandling
{
    internal class TxtFileHandling
    {
        
        public static void Create(string path)
        {
            FileStream fs=File.Create(path);
            fs.Close();
        }

        public static void Overwrite(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public static void Append(string path, string content)
        {
            File.AppendAllText(path, content);
        }

        public static void Display(string path)
        {
            string content=File.ReadAllText(path);
            Console.WriteLine(content);
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine($"File deleted: {path}");
            }
            else
            {
                Console.WriteLine($"File not found: {path}");
            }
        }
    }
}
