using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using EmployeeClass;

namespace FileHelper
{
    public static class FileClass
    {
        public static void EnterData()
        {
            int axualiryValue = 0, ageEmployee;
            string nameEmployee, carEmployee = "";
            Console.WriteLine("\nEnter data:");
            do
            {
                axualiryValue = 0;
                Console.Write("Enter name: ");
                nameEmployee = Console.ReadLine();
                nameEmployee = nameEmployee.ToLower();
                if (nameEmployee == "")
                    Console.WriteLine("Not correct.");
                for (int i = 0; i < nameEmployee.Length; i++)
                    if (char.IsLetter(nameEmployee[i]))
                        continue;
                    else
                    {
                        Console.WriteLine("Error.");
                        axualiryValue--;
                        continue;
                    }
                axualiryValue++;

                Console.Write("Enter age: ");
                string ageString = Console.ReadLine();
                bool result = int.TryParse(ageString, out ageEmployee);
                if (result == true && ageEmployee <= 99 && ageEmployee >= 18)
                    axualiryValue++;
                else
                    Console.WriteLine("Error.");

                Console.Write("Enter car (BMW, Volkswagen, Skoda): ");
                string theCar = Console.ReadLine();
                theCar = theCar.ToLower();
                Cars cars;
                if (Enum.TryParse(theCar, out cars))
                {
                    switch (cars)
                    {
                        case Cars.bmw:
                            Console.WriteLine("Your car is BMW.");
                            carEmployee = theCar;
                            break;
                        case Cars.volkswagen:
                            Console.WriteLine("Your car is Volkswagen.");
                            carEmployee = theCar;
                            break;
                        case Cars.skoda:
                            Console.WriteLine("Your car is Skoda.");
                            carEmployee = theCar;
                            break;
                    }
                    axualiryValue++;
                }
                else
                    Console.WriteLine("Error.");

                Console.Write($"Name employee: {nameEmployee}; age employee: {ageEmployee}; car employee: {carEmployee}\n\n");

            } while (axualiryValue != 3);

            if (axualiryValue == 3)
                PathHelper(nameEmployee, ageEmployee, carEmployee);
        }
        public static void ViewData()
        {
            Console.WriteLine("\nView data:");
            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            foreach (var data in restoredData)//{}
                Console.WriteLine($"{JsonSerializer.Serialize(data).Replace("{", "").Replace("}", "")}");
            Console.WriteLine("\n");
        }
        public static void FindData()
        {
            Console.Write("\nFind employee (enter name or age or car (BMW, Volkswagen, Skoda)): ");
            string information = Console.ReadLine();
            information = information.ToLower();
            int ageAfterParse = 0, check = 0, ageEmployee = 0, axualiryValue = 0;
            string nameEmployee = "", carEmployee = "";

            check = CheckFunction(information, check);
            if (check != 0)
                ageAfterParse = int.Parse(information);

            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            foreach (var data in restoredData)
            {
                ageEmployee = int.Parse(data.Age.ToString());
                nameEmployee = data.Name.ToString();
                carEmployee = data.Car.ToString();

                if (information == nameEmployee)
                    Console.WriteLine($"{JsonSerializer.Serialize(data).Replace("{", "").Replace("}", "")}");
                else if (information == carEmployee)
                    Console.WriteLine($"{JsonSerializer.Serialize(data).Replace("{", "").Replace("}", "")}");
                else if (ageAfterParse == ageEmployee)
                    Console.WriteLine($"{JsonSerializer.Serialize(data).Replace("{", "").Replace("}", "")}");
                else if (axualiryValue >= restoredData.Count - 1)
                    Console.WriteLine("Name or age or car not found.");
                else
                    axualiryValue++;
            }
            Console.WriteLine("\n");
        }
        public static void DeleteData()
        {
            Console.Write("\nDelete employee (enter name): ");
            string information = Console.ReadLine();
            information = information.ToLower();
            string nameEmployee = "";
            int axualiryValue = 0;

            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Employee>>(jsonString);

            foreach (var data in restoredData)
            {
                nameEmployee = data.Name.ToString();
                if (information == nameEmployee)
                    restoredData.Remove(data);
                else if (information != nameEmployee && axualiryValue < restoredData.Count - 1)
                    Console.WriteLine("Name not found.\n");
                else
                    axualiryValue++;
            }
            foreach (var data in restoredData)       
                Console.WriteLine($"{JsonSerializer.Serialize(data).Replace("{", "").Replace("}", "")}");

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
            Console.WriteLine("\n");
        }
        public static void CreateDeleteFile()
        {
            Console.Write("\nWhat do want do: create file or delete file? Enter c or d: ");
            string selection = Console.ReadLine();
            if (selection=="c") {
                Console.Write("Create new file.\nEnter file name: ");
                string nameFile = Console.ReadLine();
                nameFile += ".json";
                File.Create(nameFile);
            }
            else if (selection =="d") {
                Console.Write("Delete text file. Enter file name: ");
                try
                {
                    string nameFile = Console.ReadLine();
                    nameFile += ".json";
                    File.Delete(nameFile);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
                Console.WriteLine("Not correct symbol was entered.\n");
            Console.WriteLine("\n");
        }
        public static void PathHelper(string nameEmployee, int ageEmployee, string carEmployee)
        {
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };

            int id = 1;
            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Employee>>(jsonString);
            foreach (var data in restoredData)
                id = int.Parse(data.Id.ToString());
            id += 1;

            restoredData.Add(new Employee()
            {
                Id = id,
                Name = nameEmployee,
                Age = ageEmployee,
                Car = carEmployee
            }
            );

            using (StreamWriter file = File.CreateText(fileName))
            {
                string data = JsonSerializer.Serialize<List<Employee>>(restoredData, options);
                file.Write(data);
            }
        }
        public static int CheckFunction(string information, int check)
        {
            if (information == "")
                Console.WriteLine("\nNot correct.");

            for (int i = 0; i < information.Length; i++)
            {
                if (char.IsLetter(information[i]))
                    continue;
                else if ((char)(information[i]) < '9' || (char)(information[i]) > '0')
                {
                    check = 1;
                    continue;
                }
                else
                {
                    Console.WriteLine("Error.");
                    continue;
                }
            }
            return check;
        }
    }
}
