using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace lesson5task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите что-нибудь: ");
            string stringToSave = Console.ReadLine();
            string fileName = "text.txt";
            File.WriteAllText(fileName, stringToSave);
            Console.ReadKey();
        }
    }
}