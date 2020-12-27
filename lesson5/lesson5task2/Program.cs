using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson5task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "text.txt";
            FileInfo fileNameInfo;
            long lengthFile = 0;

            if (File.Exists("text.txt"))
            {
                fileNameInfo = new FileInfo(fileName);
                lengthFile = fileNameInfo.Length;
            }
            else
            {
                File.Create("text.txt").Close();
            }

            if (lengthFile == 0)
            {
                File.AppendAllText(fileName, DateTime.Now.ToLongTimeString());
            }
            else
            {
                File.AppendAllText(fileName, Environment.NewLine);
                File.AppendAllText(fileName, DateTime.Now.ToLongTimeString());
            }
            Console.ReadKey();
        }
    }
}
