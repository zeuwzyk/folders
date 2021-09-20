using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace example5
{
    static class FileManager
    {
        public static void RemoveFromFile(string name, string fileName, string checkValue)
        {
            int testValue = 0;

            if (checkValue == "json")
            {
                string jsonString = File.ReadAllText(fileName);
                var restoredData = JsonSerializer.Deserialize<List<DataEmployee>>(jsonString);

                foreach (var data in restoredData.ToArray())
                {
                    string nameEmployee = data.Name.ToString();
                   
                    if (name == nameEmployee)
                    {
                        restoredData.Remove(data);
                        testValue = 1;
                    }
                    else if (testValue == restoredData.Count - 1)
                    {
                        MessageBox.Show("Name not found.", "Message");
                        testValue = 0;
                    }
                    else
                    {
                        testValue++;
                    }
                }

                foreach (var data in restoredData)
                {
                    Console.WriteLine($"{JsonSerializer.Serialize(data)}");
                }

                var options = new JsonSerializerOptions
                {
                    AllowTrailingCommas = true,
                    WriteIndented = true
                };

                using (StreamWriter file = File.CreateText(fileName))
                {
                    string dataJson = JsonSerializer.Serialize(restoredData, options);
                    file.Write(dataJson);
                }
            }
            else
            {
                XDocument docXml = XDocument.Load(fileName);

                foreach (XElement employeeData in docXml.Element("root").Elements("employee").ToList())
                {
                    if (employeeData.Element("name").Value == name)
                    {
                        employeeData.Remove();
                    }
                    else if (testValue == docXml.Element("root").Elements("employee").Count() - 1)
                    {
                        MessageBox.Show("Name not found.", "Message");
                    }
                    else
                    {
                        testValue++;
                    }
                }

                docXml.Save(fileName);
            }
        }
    }
}