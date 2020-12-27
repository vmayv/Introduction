using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson5task4
{
    class Program
    {
        static void GetAllDirectoriesAndFiles(string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            Console.WriteLine(path);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }

            for (int i = 0; i < dirs.Length; i++)
            {
                GetAllDirectoriesAndFiles(dirs[i]);
            }
        }

        static void GetAllDirectoriesAndFilesNorecursion(string path)
        {
            string[] dirs = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            PrintFiles(path);
            for (int i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine(dirs[i]);
                PrintFiles(dirs[i]);

            }
        }

        static void PrintFiles(string path)
        {
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите директорию: ");
            string directory = Console.ReadLine();
            GetAllDirectoriesAndFiles(directory);
            Console.WriteLine();
            GetAllDirectoriesAndFilesNorecursion(directory);
            Console.ReadKey();
        }
    }
}
