using System;
using FileHelper;

namespace example3
{  
    class Program
    {        
        static void Main(string[] args)
        {
            string selection = "";
            while (selection != "0")
            {
                Console.Write("Menu:\nCommands:\n e - enter data\n v - view data\n f - find data\n " +
                    "d - delete data\n cd - create or delete file\n 0 - exit\n");
                Console.Write("Enter the command: ");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "e":
                        FileClass.EnterData();
                        break;
                    case "v":
                        FileClass.ViewData();
                        break;
                    case "f":
                        FileClass.FindData();
                        break;
                    case "d":
                        FileClass.DeleteData();
                        break;
                    case "cd":
                        FileClass.CreateDeleteFile();
                        break;
                    case "0":
                        Console.WriteLine("\nExit.");
                        Console.ReadKey();
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("\nError. Not correct symbol was entered.\n");
                        break;
                }
            }
            Console.WriteLine("\n");
        }        
    }
}
