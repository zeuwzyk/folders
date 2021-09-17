using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace example4_a
{
    static class FileManager
    {
        public static void RemoveFromXml(string name, string fileName)
        {
            int checkValue = 0;
            XDocument xdoc = XDocument.Load(fileName);

            foreach (XElement employeeData in xdoc.Element("root").Elements("employee").ToList())
            {
                if (employeeData.Element("name").Value == name)
                {
                    employeeData.Remove();
                }
                else if (checkValue == xdoc.Element("root").Elements("employee").Count() - 1)
                {
                    MessageBox.Show("Name not found.", "Message");
                }
                else
                {
                    checkValue++;
                }
            }
            xdoc.Save(fileName);
        }

        public static void RemoveFromJson(string name, string fileName)
        {
            int checkValue = 0;
            string jsonString = File.ReadAllText(fileName);
            var restoredData = JsonSerializer.Deserialize<List<DataEmployee>>(jsonString);

            foreach (var data in restoredData.ToArray())
            {
                string nameEmployee = data.Name.ToString();
                if (name == nameEmployee)
                {
                    restoredData.Remove(data);
                    checkValue = 1;
                }
                else if (checkValue == restoredData.Count - 1)
                {
                    MessageBox.Show("Name not found.", "Message");
                    checkValue = 0;
                }
                else
                {
                    checkValue++;
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
    }
}