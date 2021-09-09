using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace example3
{
    class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Car { get; set; }
    }
    class Program//sotrudniki!
    {
        enum Cars
        {
            BMW,
            Volkswagen,
            Skoda
        }
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            string selection = "";
            while (selection != "0")
            {
                Console.Write("Menu:\nCommands:\n e - enter data\n v - view data\n f - find data\n d - delete data\n 0 - exit\n");
                Console.Write("Enter the command: ");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "e":
                        EnterDataFunc();
                        break;
                    case "v":
                        ViewDataFunc();
                        break;
                    case "f":
                        FindDataFunc();
                        break;
                    case "d":
                        DeleteDataFunc();
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
        public static void EnterDataFunc()
        {
            int axualiryValue = 0, age;
            string name, carCar = "";
            Console.WriteLine("\nEnter data:");
            do
            {
                axualiryValue = 0;
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                if (name == "")
                    Console.WriteLine("Not correct.");
                for (int i = 0; i < name.Length; i++)
                    if (char.IsLetter(name[i]))
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
                bool result = int.TryParse(ageString, out age);
                if (result == true && age <= 99 && age >= 18)
                    axualiryValue++;
                else
                    Console.WriteLine("Error.");

                Console.Write("Enter car (BMW, Volkswagen, Skoda): ");
                string theCar = Console.ReadLine();
                Cars car;
                if (Enum.TryParse(theCar, out car))// шрифты
                {
                    switch (car)
                    {
                        case Cars.BMW:
                            Console.WriteLine("Your car is BMW.");
                            carCar = theCar;
                            break;
                        case Cars.Volkswagen:
                            Console.WriteLine("Your car is Volkswagen.");
                            carCar = theCar;
                            break;
                        case Cars.Skoda:
                            Console.WriteLine("Your car is Skoda.");
                            carCar = theCar;
                            break;
                    }
                    axualiryValue++;
                }
                else
                    Console.WriteLine("Error.");

                Console.Write($"name: {name}; age: {age}; car: {carCar}\n\n");
                
            } while (axualiryValue != 3);

            if (axualiryValue == 3)
                pathFunc(name, age, carCar);
        }
        public static void ViewDataFunc()
        {
            Console.WriteLine("\nView data:");
            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Data>>(jsonString);
            foreach (var data in restoredData)//{}
                Console.WriteLine($"{JsonSerializer.Serialize(data)}");            
            Console.WriteLine("\n");
        }
        public static void FindDataFunc()
        {
            Console.Write("\nFind employee (enter name or age or car (BMW, Volkswagen, Skoda)): ");
            string information = Console.ReadLine();
            int age = 0, check = 0, ages = 0, axualiryValue = 0;
            string name = "", car = "";

            check = CheckFunc(information, check);
            if (check != 0)
                age = int.Parse(information);

            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Data>>(jsonString);
            foreach (var data in restoredData)
            {
                ages = int.Parse(data.Age.ToString());
                name = data.Name.ToString();
                car = data.Car.ToString();
                if (information == name)
                {
                    Console.WriteLine($"\n{JsonSerializer.Serialize(data)}\n");
                    axualiryValue++;
                    break;
                }
                else if (information == car)
                {
                    Console.WriteLine($"\n{JsonSerializer.Serialize(data)}\n");
                    axualiryValue++;
                    break;
                }
                else if (age == ages)
                {
                    Console.WriteLine($"\n{JsonSerializer.Serialize(data)}\n");
                    axualiryValue++;
                    break;
                }
                else if (information != name && information != car && age != ages && axualiryValue != 1)
                {
                    Console.WriteLine("Name or age or car not found.\n");
                    break;
                }
                else
                    Console.WriteLine("Error.");
            }
        }
        public static void DeleteDataFunc()
        {
            Console.Write("\nDelete employee (enter name): ");
            string information = Console.ReadLine();
            string name = "";
            int axualiryValue = 0;

            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Data>>(jsonString);

            
            foreach (var data in restoredData)
            {
                name = data.Name.ToString();
                if (information == name)
                {
                    restoredData.Remove(data);
                    axualiryValue++;
                    break;
                }
                else if (information != name && axualiryValue == 3)
                {
                    Console.WriteLine("Name not found.\n");
                    break;
                }
            }
            foreach (var data in restoredData)     //{}       
                Console.WriteLine($"{JsonSerializer.Serialize(data)}");
            
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };
            
            using (StreamWriter file = File.CreateText(fileName))
            {
                string data = JsonSerializer.Serialize<List<Data>>(restoredData, options);
                file.Write(data);
            }
            Console.WriteLine("\n");
        }
        public static void pathFunc(string name, int age, string car)
        {
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };
            int id = 1;

            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Data>>(jsonString);
            foreach (var data in restoredData)
            {
                id = int.Parse(data.Id.ToString());
            }
            id += 1;

            restoredData.Add(new Data()
            {
                Id = id,
                Name = name,
                Age = age,
                Car = car
            }
            );

            using (StreamWriter file = File.CreateText(fileName))
            {
                string data = JsonSerializer.Serialize<List<Data>>(restoredData, options);
                file.Write(data);
            }
        }
        public static int CheckFunc(string information, int check)
        {
            if (information == "")
                Console.WriteLine("\nNot correct.");

            for (int i = 0; i < information.Length; i++)
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
            return check;
        }
    }
}
