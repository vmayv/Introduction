using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson5task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел набор чисел от 0 до 255: ");
            string fileName = "bytes.bin";
            string[] array = Console.ReadLine().Split(' ');
            byte[] arrayByte = new byte[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayByte[i] = Convert.ToByte(array[i]);
            }

            File.WriteAllBytes(fileName, arrayByte);
            byte[] fromFile = File.ReadAllBytes(fileName);
            for (int i = 0; i < fromFile.Length; i++)
            {
                Console.Write($"{fromFile[i]} ");
            }
            Console.ReadKey();
        }
    }
}
