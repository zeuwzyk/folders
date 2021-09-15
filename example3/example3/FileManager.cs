using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace example3
{
    class FileManager
    {
        public static void EnterData(string fileName)
        {
            int checkValue = 0;
            int ageEmployee;
            string nameEmployee;
            string carEmployee = "";

            Console.WriteLine("\nEnter data:");

            do
            {
                Console.Write("Enter name: ");
                nameEmployee = Console.ReadLine();
                nameEmployee = nameEmployee.ToLower();

                for (int i = 0; i < nameEmployee.Length; i++)
                {
                    if (!char.IsLetter(nameEmployee[i]))
                    {
                        Console.WriteLine("Not correct symbol was entered.");
                        checkValue = 0;
                        break;
                    }
                    else
                    {
                        checkValue = 1;
                    }
                }
            } while (checkValue == 0);

            do
            {
                Console.Write("Enter age: ");
                string ageString = Console.ReadLine();
                bool result = int.TryParse(ageString, out ageEmployee);

                if (result && ageEmployee <= 99 && ageEmployee >= 18)
                {
                    checkValue = 1;
                }
                else
                {
                    Console.WriteLine("Not correct age was entered.");
                    checkValue = 0;
                }
            } while (checkValue == 0);

            do
            {
                Console.Write("Enter car (BMW, Volkswagen, Skoda): ");
                string car = Console.ReadLine();
                car = car.ToLower();
                Cars cars;

                if (Enum.TryParse(car, out cars))
                {
                    switch (cars)
                    {
                        case Cars.bmw:
                            Console.WriteLine("Your car is BMW.");
                            carEmployee = car;
                            break;
                        case Cars.volkswagen:
                            Console.WriteLine("Your car is Volkswagen.");
                            carEmployee = car;
                            break;
                        case Cars.skoda:
                            Console.WriteLine("Your car is Skoda.");
                            carEmployee = car;
                            break;
                    }
                    checkValue = 1;
                }
                else
                {
                    Console.WriteLine("Not correct name of car was entered.");
                    checkValue = 0;
                }
            } while (checkValue == 0);

            Console.Write($"Name employee: {nameEmployee}; age employee: {ageEmployee}; car employee: {carEmployee}\n\n");

            FileHelper.SaveFile(nameEmployee, ageEmployee, carEmployee, fileName);
        }

        public static void ViewData(string fileName)
        {
            Console.WriteLine("\nView data:");

            List<Employee> restoredData = FileHelper.OpenFile(fileName);

            foreach (var data in restoredData)
            {
                Console.WriteLine($"{JsonSerializer.Serialize(data).Replace("{", "").Replace("}", "")}");
            }
        }

        public static void FindData(string fileName)
        {
            int checkValue = 0;
            int check = 0;
            int countValue = 0;

            int ageAfterParse = 0;
            int ageEmployee;
            string nameEmployee;
            string carEmployee;

            ViewData(fileName);
            Console.WriteLine("\n");

            do
            {
                Console.Write("Find employee (enter name or age or car (BMW, Volkswagen, Skoda)): ");
                string information = Console.ReadLine();
                information = information.ToLower();

                check = Validation(information, check);

                if (check != 0)
                {
                    ageAfterParse = int.Parse(information);
                }

                List<Employee> restoredData = FileHelper.OpenFile(fileName);

                foreach (var data in restoredData)
                {
                    ageEmployee = int.Parse(data.Age.ToString());
                    nameEmployee = data.Name.ToString();
                    carEmployee = data.Car.ToString();

                    if (information == nameEmployee)
                    {
                        Console.WriteLine($"{JsonSerializer.Serialize(data).Replace("{", "").Replace("}", "")}");
                        checkValue = 1;
                    }
                    else if (information == carEmployee)
                    {
                        Console.WriteLine($"{JsonSerializer.Serialize(data).Replace("{", "").Replace("}", "")}");
                        checkValue = 1;
                    }
                    else if (ageAfterParse == ageEmployee)
                    {
                        Console.WriteLine($"{JsonSerializer.Serialize(data).Replace("{", "").Replace("}", "")}");
                        checkValue = 1;
                    }
                    else if (countValue >= restoredData.Count - 1)
                    {
                        Console.WriteLine("Name or age or car not found.");
                        checkValue = 0;
                    }
                    else
                    {
                        countValue++;
                    }
                }
                countValue = 0;
            } while (checkValue == 0);
        }

        public static void DeleteData(string fileName)
        {
            string nameEmployee;
            int checkValue = 0;
            int countValue = 0;

            List<Employee> restoredData = FileHelper.OpenFile(fileName);

            ViewData(fileName);
            Console.WriteLine("\n");

            do
            {
                Console.Write("Delete employee (enter name): ");
                string information = Console.ReadLine();
                information = information.ToLower();

                foreach (var data in restoredData.ToArray())
                {
                    nameEmployee = data.Name.ToString();
                    if (information == nameEmployee)
                    {
                        restoredData.Remove(data);
                        checkValue = 1;
                    }
                    else if (countValue == restoredData.Count - 1)
                    {
                        Console.WriteLine("Name not found.");
                        checkValue = 0;
                    }
                    else
                    {
                        countValue++;
                    }
                }
                countValue = 0;
            } while (checkValue == 0);

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

        public static int Validation(string information, int check)
        {
            if (information == "")
            {
                Console.WriteLine("Enter information.");
            }

            for (int i = 0; i < information.Length; i++)
            {
                if (char.IsLetter(information[i]))
                {
                    check = 0;
                }
                else if ((char)(information[i]) < '9' || (char)(information[i]) > '0')
                {
                    check = 1;
                }
                else
                {
                    Console.WriteLine("Error.");
                    check = 0;
                }
            }
            return check;
        }
    }
}
