using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace example4_a
{
    static class FileManager//удаление из файлов
    {
        public static void RemoveFromXml(string name, string fileName)
        {
            int axualiryValue = 0;
            XDocument xdoc = XDocument.Load(fileName);

            foreach (XElement employeeData in xdoc.Element("root").Elements("employee").ToList())
            {
                if (employeeData.Element("name").Value == name)
                {
                    employeeData.Remove();
                }
                else if (axualiryValue == xdoc.Element("root").Elements("employee").Count() - 1)
                {
                    MessageBox.Show("Name not found. \n", null, MessageBoxButtons.OK);
                }
                else
                {
                    axualiryValue++;
                }
            }
            xdoc.Save(fileName);
        }

        public static void RemoveFromJson(string name, string fileName)
        {
            int axualiryValue = 0;
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<DataEmployee>>(jsonString);

            foreach (var data in restoredData)
            {
                string nameEmployee = data.Name.ToString();
                if (name == nameEmployee)
                {
                    restoredData.Remove(data);
                }
                else if (axualiryValue == restoredData.Count - 1)
                {
                    MessageBox.Show("Name not found.\n", null, MessageBoxButtons.OK);
                }
                else
                {
                    axualiryValue++;
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
                string data = JsonSerializer.Serialize(restoredData, options);
                file.Write(data);
            }
        }
    }
}