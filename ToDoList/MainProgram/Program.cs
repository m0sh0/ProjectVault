using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MainProgram
{
    internal class Program
    {
        static List<string> tasks = new();
        static string filePath = "tasks.txt";
        static void Main(string[] args)
        {
         Console.OutputEncoding = Encoding.UTF8;
         ShowLoading("Loading tasks");
         LoadTasks();

            ShowHeader();
            ShowMenu();


            while (true)
            {
                Console.Write("Input: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    AddTask();
                }
                else if (input == "2")
                {
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks added yet.");
                    }
                    else
                    {
                        PrintTasks();
                    }
                }
                else if (input == "3")
                {
                    CompletedTask();
                }
                else if (input == "4")
                {
                    RemoveTask();
                }
                else if (input == "5")
                {
                    SaveTasks();
                    Console.WriteLine("Tasks saved. Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again!");
                }

  
            }
  
        }

        static void ShowHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===========================================");
            Console.WriteLine("            <<<TO-DO LIST APP>>>           ");
            Console.WriteLine("===========================================");
            Console.ResetColor();
        }

        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1.Add task");
            Console.WriteLine("2.View tasks");
            Console.WriteLine("3.Mark task as completed");
            Console.WriteLine("4.Remove task");
            Console.WriteLine("5.Exit");
            Console.ResetColor();
        }

        static void SaveTasks()
        {
            File.WriteAllLines(filePath, tasks);
        }

        static void RemoveTask()
        {
            PrintTasks();
            Console.WriteLine("Enter a task you want to remove: ");

            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
            {
                tasks.RemoveAt(index - 1);
                Console.WriteLine("Task removed");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        static void CompletedTask()
        {
            PrintTasks();
            Console.WriteLine("Enter task number to mark as completed: ");

            if (int.TryParse(Console.ReadLine(),out int index) && index > 0 && index <= tasks.Count)
            {
                tasks[index - 1] = "[^] " + tasks[index - 1].Substring(4);
                Console.WriteLine("Task marked as completed!");
            }
        }

        static void AddTask()
        {
            Console.WriteLine("What task would you like to add?");
            Console.Write("Task name: ");
            string task = Console.ReadLine();

            if (tasks.Contains(task))
            {
                Console.WriteLine("You already have this task.");
                return;
            }

            tasks.Add("[ ] " + task);
            Console.WriteLine("\nTask added");
        }

        static void PrintTasks()
        {
            Console.WriteLine("\nYour tasks:");

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].StartsWith("[^]"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            Console.ResetColor();
        }

        static void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                tasks.Clear();
                tasks.AddRange(File.ReadAllLines(filePath));
                Console.WriteLine("Tasks loaded from 'tasks.txt'.");
            }
            else
            {
                Console.WriteLine("No saved tasks.");
            }
        }

        static void ShowLoading(string message)
        {
            Console.WriteLine(message);

            for (int i = 0; i < 3; i++)
            {
                Console.Write('.');
                System.Threading.Thread.Sleep(500);
            }

            Console.WriteLine();
        }


    }
}
