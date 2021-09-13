using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FileHelper
{
    public class FileClass
    {        public static void pathFunc(string name, int age, string car)
        {
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };
            int id = 1;

            string fileName = "user.json";
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<Data.DataClass>>(jsonString);
            foreach (var data in restoredData)
            {
                id = int.Parse(data.Id.ToString());
            }
            id += 1;

            restoredData.Add(new Data.DataClass()
            {
                Id = id,
                Name = name,
                Age = age,
                Car = car
            }
            );

            using (StreamWriter file = File.CreateText(fileName))
            {
                string data = JsonSerializer.Serialize<List<Data.DataClass>>(restoredData, options);
                file.Write(data);
            }
        }
    }
}
