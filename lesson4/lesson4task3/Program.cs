using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(GetSeasonName(GetSeason(monthNumber)));
            Console.ReadKey();
        }

        enum Seasons
        {
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }

        static Seasons GetSeason(int monthNumber)
        {
            switch (monthNumber)
            {
                case 12:
                case 1:
                case 2:
                    return Seasons.Winter;
                case 3:
                case 4:
                case 5:
                    return Seasons.Spring;
                case 6:
                case 7:
                case 8:
                    return Seasons.Summer;
                default:
                    return Seasons.Autumn;
            }
        }

        static string GetSeasonName(Seasons Season)
        {
            switch (Season)
            {
                case Seasons.Winter:
                    return "Зима";
                case Seasons.Spring:
                    return "Весна";
                case Seasons.Summer:
                    return "Лето";
                default:
                    return "Осень";
            }

        }
    }
}