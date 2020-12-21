using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4task1
{
    class Program
    {
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {patronymic} {lastName}";
        }

        static void Main(string[] args)
        {
            string firstName1 = "Иван";
            string lastName1 = "Иванов";
            string patronymic1 = "Иванович";
            string firstName2 = "Петр";
            string lastName2 = "Петров";
            string patronymic2 = "Петрович";
            string firstName3 = "Андрей";
            string lastName3 = "Андреев";
            string patronymic3 = "Андреевич";
            Console.WriteLine(GetFullName(firstName1, lastName1, patronymic1));
            Console.WriteLine(GetFullName(firstName2, lastName2, patronymic2));
            Console.WriteLine(GetFullName(firstName3, lastName3, patronymic3));
            Console.ReadKey();
        }
    }
}
