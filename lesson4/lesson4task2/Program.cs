using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4task2
{
    class Program
    {
        static int Sum(string inputString)
        {
            string[] arrStr = inputString.Split(' ');
            int sum = 0;
            for (int i = 0; i < arrStr.Length; i++)
            {
                sum += Convert.ToInt32(arrStr[i]);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку из чисел через пробел: ");
            string str = Console.ReadLine();
            Console.WriteLine($"Сумма чисел в строке равна {Sum(str)}");
            Console.ReadKey();
        }
    }
}
