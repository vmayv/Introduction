using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string initialStr = Console.ReadLine();
            char[] initialStrArr = initialStr.ToCharArray();
            string reverseStr = String.Empty;

            for (int i = initialStrArr.Length - 1; i > -1; i--)
            {
                reverseStr += initialStrArr[i];
            }


            /* Ещё вариант. Без циклов.

            char[] reverseStrArr = initialStrArr.Reverse().ToArray();
            string reverseStr = new string(reverseStrArr);
            */


            /* Ещё вариант. С созданием массива

            char[] reverseStrArr= new char[initialStrArr.Length];
            for (int i = initialStrArr.Length - 1; i > -1; i--)
            {
                reverseStrArr[initialStrArr.Length - i - 1] = initialStrArr[i];
            }
            string reverseStr = new string(reverseStrArr);*/

            Console.Clear();
            Console.WriteLine($"Исходная строка: {initialStr}");
            Console.WriteLine($"Перевёрнутная строка: {reverseStr}");
            Console.ReadKey();
        }
    }
}
