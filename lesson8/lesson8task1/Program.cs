using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine(greeting);
            if (string.IsNullOrEmpty(Properties.Settings.Default.Name) && Properties.Settings.Default.Age == 0 && string.IsNullOrEmpty(Properties.Settings.Default.Job))
            {
                Console.WriteLine("Введите Ваше имя: ");
                Properties.Settings.Default.Name = Console.ReadLine();
                Console.WriteLine("Введите Ваш возраст: ");
                Properties.Settings.Default.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Ваш род деятельности: ");
                Properties.Settings.Default.Job = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.ReadKey();
            } else
            {
                Console.Clear();
                string name = Properties.Settings.Default.Name;
                int age = Properties.Settings.Default.Age;
                string job = Properties.Settings.Default.Job;
                Console.WriteLine($"{greeting} {name}");
                Console.WriteLine($"Возраст: {age}");
                Console.WriteLine($"Род деятельности: {job}");
                Console.ReadKey();
            }

        }
    }
}
