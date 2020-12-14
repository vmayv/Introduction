using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2task2
{
    enum Months
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12,
    }

    class Program
    {
        static void Main(string[] args)
        {
            int month;

            do
            {
                Console.WriteLine("Введите номер месяца от 1 до 12: ");
                month = Convert.ToInt32((Console.ReadLine()));
            }
            while (month <= 0 || month > 12);

            Console.WriteLine($"Месяц с номером {month} это {(Months)month}");
            Console.ReadKey();
            
        }
    }
}
