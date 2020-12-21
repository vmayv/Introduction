using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4task4
{
    class Program
    {
        static int Fibonacci(int i)
        { 
            if (i == 0)
            {
                return 0;
            }
            else if (i == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(i - 1) + Fibonacci(i - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите индекс числа Фибоначчи: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число Фибоначчи с индексом {x} равно {Fibonacci(x)}");
            Console.ReadKey();

        }
    }
}
