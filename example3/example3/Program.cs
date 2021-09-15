using System;

namespace example3
{  
    class Program
    {        
        static void Main(string[] args)
        {
            Console.Write("Enter name of existing file for work: ");
            string fileName = Console.ReadLine();//enter user 
            fileName += ".json";

            string selection = "";

            while (selection != "0")
            {
                Console.Write("\nMenu:\nCommands:\n e - enter data\n v - view data\n f - find data\n " +
                    "d - delete data\n cd - create or delete file\n 0 - exit\n");
                Console.Write("Enter the command: ");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "e":
                        FileManager.EnterData(fileName);
                        break;
                    case "v":
                        FileManager.ViewData(fileName);
                        break;
                    case "f":
                        FileManager.FindData(fileName);
                        break;
                    case "d":
                        FileManager.DeleteData(fileName);
                        break;
                    case "cd":
                        FileHelper.CreateDeleteFile();
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
