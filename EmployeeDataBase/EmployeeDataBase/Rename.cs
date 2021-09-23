using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeDataBase
{
    class Rename
    {

       // public class FileManager
       // {
            public static Form1 form1 = new Form1();//создается форма
            //public static void OpenDataBase()
            //{
            //    using (DataBaseManager db = new DataBaseManager())//мб как-то вынести в fileManager
            //    {
            //        var employee = db.Employees.ToList();

            //        foreach (DataEmployee de in employee)
            //        {
            //            form1.FillingGrid(de.Id, de.Name, de.Age, de.Car);//параша
            //        }
            //    }
            //}

            public void SaveDataBase(string nameEmployee, int ageEmployee, string carEmployee)
            {
                using (DataBaseManager db = new DataBaseManager())
                {
                    //int id1 = 0;

                    //if (form1.employeeGridView.Rows.Count == 1)
                    //{
                    //    id1 = 0;
                    //}
                    //else
                    //{
                    //    var id = db.Employees.OrderBy(x => x.Id).Last();
                    //    id1 = id.Id;
                    //}

                    //DataEmployee employee = new DataEmployee
                    //{
                    //    Id = id1 + 1,
                    //    Name = nameEmployee,
                    //    Age = ageEmployee,
                    //    Car = carEmployee
                    //};

                    //db.Employees.Add(employee);
                    //db.SaveChanges();
                }
            }
        
    }
}
