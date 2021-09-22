using System.Linq;

namespace EmployeeDataBase
{
    class FileManager
    {
        //public void OpenDataBase()
        //{
        //    using (DataBaseManager db = new DataBaseManager())//мб как-то вынести в fileManager
        //    {
        //        var employee = db.Employees.ToList();
        //        foreach (DataEmployee de in employee)
        //        {
        //            FillingGrid(de.Id, de.Name, de.Age, de.Car);
        //        }
        //    }
        //}

        public static void SaveDataBase(string nameEmployee, int ageEmployee, string carEmployee)
        {
            using (DataBaseManager db = new DataBaseManager())//вызов функции из dataamanager <-> datahelper
            {
                //var id = db.Employees.Last().Id + 1;
                //var id = db.Empl
                DataEmployee employee = new DataEmployee
                {
                   // Id = id,
                    Name = nameEmployee,
                    Age = ageEmployee,//не знаю как в стринг и есть ли смысл
                    Car = carEmployee
                };

                db.Employees.Add(employee);
                FileHelper.SaveFile();//как правильно тут надо поступить
            }
        }
    }
}