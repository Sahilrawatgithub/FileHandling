using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filehandling
{
    internal class CSVFileHandling
    {
        public static void Create(string filename)
        {
            FileStream fs=File.Create(filename);
            fs.Close();
        }

        public static void Overwrite(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }

        public static void Append(string filename, string content)
        {
            File.AppendAllText(filename, content);
        }

        public static void Display(string path)
        {
            string content = File.ReadAllText(path);
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
