using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace lesson5task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("tasks.json");
            List<Task> tasks = JsonSerializer.Deserialize<List<Task>>(json);

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < tasks.Count; i++)
                {
                    Task task = tasks[i];
                    int taskNumber = i + 1;
                    Console.WriteLine($"{(task.IsDone ? "[x]" : "[ ]")} {taskNumber} {task.Title}");
                }

                Console.WriteLine("Введите номер задачи для изменения статуса или Q для выхода:");

                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    return;
                }

                if (int.TryParse(input, out int taskIndex))
                {
                    ChangeTaskStatus(tasks, taskIndex - 1);
                }
                else
                {
                    Console.WriteLine("ERROR!");
                    Console.ReadKey();
                }
            }
        }

        static void ChangeTaskStatus(List<Task> tasks, int taskIndex)
        {
            tasks[taskIndex].IsDone = !tasks[taskIndex].IsDone;
            var json = JsonSerializer.Serialize(tasks);
            File.WriteAllText("tasks.json", json);
        }
    }
}