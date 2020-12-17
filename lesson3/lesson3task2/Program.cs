using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Телефонный справочник");
            Console.WriteLine("Введите количество записей: ");
            int count = Convert.ToInt32(Console.ReadLine());
            string[,] telephones = new string[count, 2];
            Console.Clear();


            for (int i = 0; i < telephones.GetLength(0); i++)
            {
                Console.WriteLine($"Введите имя для {i + 1} записи: ");
                string x = Console.ReadLine();
                telephones[i, 0] = x;
                Console.WriteLine($"Введите номер телефона для {i + 1} записи: ");
                string y = Console.ReadLine();
                telephones[i, 1] = y;
            }

            Console.WriteLine($"Ваш телефонный справочник содержит {count} строк: \n");

            for (int i = 0; i < telephones.GetLength(0); i++)
            {
                Console.WriteLine($"{telephones[i, 0]} \t {telephones[i, 1]}");
            }
            Console.ReadKey();
        }
    }
}
