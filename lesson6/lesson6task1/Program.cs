using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lesson6task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Process[] processes = Process.GetProcesses();
                Console.WriteLine("ID процесса\tИмя процесса\tПотребление памяти");
                Console.WriteLine();
                for (int i = 0; i < processes.Length; i++)
                {
                    Console.WriteLine($"{processes[i].Id}\t{processes[i].ProcessName}\t{processes[i].VirtualMemorySize64 / 1000} KB");
                }
                Console.WriteLine();
                Console.WriteLine("Введите ID/название процесса для его завершения или Q для выхода:");
                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    return;
                }

                int a = 0;
                if (int.TryParse(input, out a))
                {
                    EndProcess(a, processes);
                }
                else
                {
                    EndProcess(input, processes);
                }
            }
        }

        static void EndProcess(int processId, Process[] processes)
        {
            bool isProcessFound = false;
            for (int i = 0; i < processes.Length; i++)
            {
                if (processes[i].Id == processId)
                {
                    isProcessFound = true;
                    processes[i].Kill();
                }
            }
            if (!isProcessFound)
            {
                Console.WriteLine($"Не найден процесс с id {processId}");
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
            }
        }

        static void EndProcess(string processName, Process[] processes)
        {
            bool isProcessFound = false;
            for (int i = 0; i < processes.Length; i++)
            {
                if (processes[i].ProcessName == processName)
                {
                    isProcessFound = true;
                    processes[i].Kill();
                }
            }
            if (!isProcessFound)
            {
                Console.WriteLine($"Не найден процесс с именем {processName}");
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
            }
        }
    }
}
