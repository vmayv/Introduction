using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nums = new string[10, 10] {
                { "x", "o", "o", "o", "o", "o", "o", "o", "x", "x" },
                { "x", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
                { "o", "o", "x", "x", "x", "x", "o", "o", "o", "o" },
                { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
                { "x", "x", "o", "o", "o", "o", "o", "o", "o", "o" },
                { "o", "o", "o", "x", "o", "o", "o", "o", "o", "o" },
                { "o", "o", "o", "x", "o", "x", "x", "x", "o", "o" },
                { "o", "o", "o", "x", "o", "o", "o", "o", "o", "o" },
                { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
                { "x", "o", "x", "o", "x", "o", "o", "o", "x", "o" },
                };

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write($"{nums[i, j]} ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
