using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace example3
{
    static class FileHelper//статик  разобраться
    {        
        public static void CreateDeleteFile()
        {
            string selection;
            int checkValue = 0;//**

            do
            {
                Console.Write("\nWhat do want do: create file or delete file? Enter c or d or 0 (exit): ");
                selection = Console.ReadLine();

                if (selection == "c")
                {
                    Console.Write("Create new file.\nEnter file name: ");
                    string nameFile = Console.ReadLine();
                    nameFile += ".json";
                    File.Create(nameFile);
                    checkValue = 1;
                }
                else if (selection == "d")
                {
                    Console.Write("Delete text file. Enter file name: ");

                    try
                    {
                        string nameFile = Console.ReadLine();
                        nameFile += ".json";
                        File.Delete(nameFile);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    checkValue = 1;
                }
                else if (selection == "0")
                {
                    Console.WriteLine("Exit.");
                    checkValue = 1;
                }
                else
                {
                    Console.WriteLine("Not correct symbol was entered.\n");
                    checkValue = 0;
                }
                Console.WriteLine("\n");
            } while (checkValue==0);
        }
        public static List<Employee> OpenFile(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            List<Employee> restoredData = JsonSerializer.Deserialize<List<Employee>>(jsonString);
           return restoredData;
        }
        public static void SaveFile(string nameEmployee, int ageEmployee, string carEmployee, string fileName)
        {
            int id = 1;
            List<Employee> restoredData = FileHelper.OpenFile(fileName);

            foreach (var data in restoredData)
            { 
                id = int.Parse(data.Id.ToString()); 
            }
            id += 1;

            restoredData.Add(new Employee()
            {
                Id = id,
                Name = nameEmployee,
                Age = ageEmployee,
                Car = carEmployee
            }
            );

            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };

            using (StreamWriter file = File.CreateText(fileName))
            {
                string data = JsonSerializer.Serialize<List<Employee>>(restoredData, options);
                file.Write(data);
            }
        }        
    }
}
