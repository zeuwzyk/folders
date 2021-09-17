using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Linq;
using System.Linq;
using System.Windows.Forms;

namespace example4_a
{
    public class FileHelper
    {
        public static void SaveJson(string name, int age, string car)
        {
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };

            string fileName = "employee.json";
            string jsonString = File.ReadAllText(fileName);

            var restoredData = JsonSerializer.Deserialize<List<DataEmployee>>(jsonString);

            int id = restoredData.Last().Id + 1;

            restoredData.Add(new DataEmployee()
            {
                Id = id,
                Name = name,
                Age = age,
                Car = car
            }
            );

            using (StreamWriter file = File.CreateText(fileName))
            {
                string data = JsonSerializer.Serialize(restoredData, options);
                file.Write(data);
            }
        }

        public static void SaveXml(string name, int age, string car)
        {
            XDocument xdoc = XDocument.Load("employee.xml");
            XElement root = xdoc.Element("root");

            var id = int.Parse(root.Elements("employee").Elements("id").Last().Value) + 1;

            root.Add(new XElement("employee",
                   new XElement("id", id),
                   new XElement("name", name),
                   new XElement("age", age),
                   new XElement("car", car)));
            xdoc.Save("employee.xml");
        }

        public static string fileName = "";

        public static string OpenFile(int checkValue)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Files (*.json, *.xml) | *.json; *.xml",
                RestoreDirectory = true
            };

            if (checkValue == 1)
            {
                openFileDialog.Title = "Upload file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                }
            }

            return fileName;
        }
    }
}

