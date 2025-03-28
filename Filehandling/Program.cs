namespace Filehandling
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //string path = @"D:\BridgeLabz\Filehandling practise\Filehandling\Filehandling\file.txt";
            //TxtFileHandling.Create(path);
            //TxtFileHandling.Overwrite(path, "hi");
            //TxtFileHandling.Append(path, "\nhi has new addition as i used append");
            //TxtFileHandling.Display(path);


            //string csvpath = @"D:\BridgeLabz\Filehandling practise\Filehandling\Filehandling\file.csv";
            //CSVFileHandling.Create(csvpath);
            //CSVFileHandling.Overwrite(csvpath, "ID,Name,Age");
            //CSVFileHandling.Append(csvpath, "\n1,Sahil,21");
            //CSVFileHandling.Display(csvpath);
            ////CSVFileHandling.DeleteFile(csvpath);


            string jsonvpath = @"D:\BridgeLabz\Filehandling practise\Filehandling\Filehandling\file.json";
            JsonFileHandling.Create(jsonvpath);
            Person p = new Person("sahil", 21, "mohali");
            JsonFileHandling.Override(jsonvpath,p );

            JsonFileHandling.Append(jsonvpath,new Person("Abhishek",22,"Ziakpur"));

        }
    }
}
