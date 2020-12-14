using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2task4
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
            Console.WriteLine("Введите минимальную температуру за сутки: ");
            double minDayTemp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки: ");
            double maxDayTemp = Convert.ToDouble(Console.ReadLine());
            double averageDayTemp = (minDayTemp + maxDayTemp) / 2;
            bool isWinter = ((Months)month == Months.December || (Months)month == Months.January || (Months)month == Months.February);
            if (isWinter && averageDayTemp > 0)
            {
                Console.WriteLine($"Месяц с номером {month} это {(Months)month}");
                Console.WriteLine($"Минимальная температура за сутки: {Math.Round(minDayTemp, 1)}");
                Console.WriteLine($"Максимальная температура за сутки: {Math.Round(maxDayTemp, 1)}");
                Console.WriteLine($"Среднесуточная температура: {Math.Round(averageDayTemp, 1)}");
                Console.WriteLine("Дождливая зима!");
                Console.ReadKey();
            }
            Console.WriteLine($"Месяц с номером {month} это {(Months)month}");
            Console.WriteLine($"Минимальная температура за сутки: {Math.Round(minDayTemp, 1)}");
            Console.WriteLine($"Максимальная температура за сутки: {Math.Round(maxDayTemp, 1)}");
            Console.WriteLine($"Среднесуточная температура: {Math.Round(averageDayTemp, 1)}");
            Console.ReadKey();
        }
    }
}
