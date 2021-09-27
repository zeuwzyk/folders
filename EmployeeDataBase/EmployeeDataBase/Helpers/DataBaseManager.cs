using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeDataBase.Helpers
{
    public static class DataBaseManager
    {
        public static void Open(DataGridView employeeGridView)
        {
            using (DataBaseOpenSave db = new DataBaseOpenSave())
            {
                var employee = db.Employees.ToList();

                foreach (DataEmployee de in employee)
                {
                    GridHelper.Filling(employeeGridView, de.Id, de.Name, de.Age, de.Car);
                }
            }
        }

        public static void Save(DataGridView employeeGridView, string nameEmployee, int ageEmployee, string carEmployee)
        {
            int idEmployee;

            using (DataBaseOpenSave db = new DataBaseOpenSave())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    if (employeeGridView.Rows.Count == 1)
                    {
                        idEmployee = 0;
                    }
                    else
                    {
                        var id = db.Employees.OrderBy(x => x.Id).Last();
                        idEmployee = id.Id;
                    }

                    DataEmployee employee = new DataEmployee
                    {
                        Id = idEmployee + 1,
                        Name = nameEmployee,
                        Age = ageEmployee,
                        Car = carEmployee
                    };

                    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Employees ON;");
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    db.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Employees OFF;");
                    transaction.Commit();
                }
            }
        }

        public static void Remove(DataGridView employeeGridView, TextBox textBoxFindOrDelete, int checkValue)
        {
            checkValue = GridHelper.FindInformation(employeeGridView, checkValue, textBoxFindOrDelete.Text);

            if (checkValue == 1)
            {
                using (DataBaseOpenSave db = new DataBaseOpenSave())
                {
                    db.Employees.RemoveRange(db.Employees.Where(x => x.Name == textBoxFindOrDelete.Text));
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Information not found.", "Message");
            }
        }
    }
}