using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine($"Число {x} - чётное");
                Console.ReadKey();
            }

            Console.WriteLine($"Число {x} - нечётное");
            Console.ReadKey();
        }
    }
}
