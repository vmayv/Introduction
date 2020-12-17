using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[x, x];

            Random rnd = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(0, 50);
                }
            }

            Console.Clear();
            Console.WriteLine($"Ваш массив размером {x} на {x}: \n");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine("\nЭлементы по диагонали: \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i, i]} \t");
            }
            Console.ReadKey();
        }
    }
}
