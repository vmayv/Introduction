using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки: ");
            double minDayTemp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки: ");
            double maxDayTemp = Convert.ToDouble(Console.ReadLine());
            double averageDayTemp = (minDayTemp + maxDayTemp) / 2;
            Console.Clear();
            Console.WriteLine($"Минимальная температура за сутки: {Math.Round(minDayTemp, 1)}");
            Console.WriteLine($"Максимальная температура за сутки: {Math.Round(maxDayTemp, 1)}");
            Console.WriteLine($"Среднесуточная температура: {Math.Round(averageDayTemp, 1)}");
            Console.ReadKey();
        }
    }
}
