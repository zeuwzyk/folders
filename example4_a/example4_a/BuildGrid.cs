using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using System.Windows.Forms;

namespace example4_a
{
    static class BuildGrid
    {
        //public static void InitializationValueGrid(string fileName)
        //{
        //    if (fileName.Contains(".json"))
        //    {
        //        int ageEmployee, id;
        //        string nameEmployee, carEmployee;
        //        string jsonString = File.ReadAllText(fileName);
        //        var restoredData = JsonSerializer.Deserialize<List<DataEmployee>>(jsonString);

        //        foreach (var data in restoredData)
        //        {
        //            id = int.Parse(data.Id.ToString());
        //            ageEmployee = int.Parse(data.Age.ToString());
        //            nameEmployee = data.Name.ToString();
        //            carEmployee = data.Car.ToString();

        //            FillingGrid(id, nameEmployee, ageEmployee, carEmployee);
        //        }
        //    }
        //    else if (fileName.Contains(".xml"))
        //    {
        //        XDocument xdoc = XDocument.Load(fileName);

        //        foreach (XElement employeeData in xdoc.Element("root").Elements("employee"))
        //        {
        //            XElement IdX = employeeData.Element("id");
        //            XElement nameEmplX = employeeData.Element("name");
        //            XElement ageEmplX = employeeData.Element("age");
        //            XElement carEmplX = employeeData.Element("car");

        //            FillingGrid(int.Parse(IdX.Value), nameEmplX.Value, int.Parse(ageEmplX.Value), carEmplX.Value);
        //        }
        //    }
        //}
        //public static void FillingGrid(int id, string nameEmployee, int ageEmployee, string carEmployee)//??
        //{
        //    int rowNumber = dataGridView1.Rows.Add();
        //    dataGridView1.Rows[rowNumber].Cells["col1"].Value = id;
        //    dataGridView1.Rows[rowNumber].Cells["col2"].Value = nameEmployee;
        //    dataGridView1.Rows[rowNumber].Cells["col3"].Value = ageEmployee;
        //    dataGridView1.Rows[rowNumber].Cells["col4"].Value = carEmployee;
        //}
    }
}
