using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;

namespace Employee.Helpers
{
    public static class DataBaseManager
    {
        public static int Open(DataGridView employeeGridView)
        {
            int checkValue = 0;

            try
            {
                ConnectToDataBase db = new ConnectToDataBase();
                var employee = db.Employees.ToList();//

                foreach (DataEmployee de in employee)
                {
                    GridHelper.Filling(employeeGridView, de.Id, de.Name, de.Age, de.Car);
                }
            }
            catch
            {
                MessageBox.Show("Database is not opened.", "Message");
                checkValue = 0;
            }

            return checkValue;
        }

        public static void Save(string nameEmployee, int ageEmployee, string carEmployee)
        {         
            try
            {
                ConnectToDataBase db = new ConnectToDataBase();
                var transaction = db.Database.BeginTransaction();

                DataEmployee employee = new DataEmployee
                {
                    Id = nameEmployee.GetHashCode() + ageEmployee.GetHashCode() + carEmployee.GetHashCode(),
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
            catch
            {
                MessageBox.Show("Data is not saved.", "Message");
            }
        }

        public static void Delete(DataGridView employeeGridView, TextBox textBoxFindOrDelete, int checkValue)
        {
            checkValue = GridHelper.FindInformation(employeeGridView, checkValue, textBoxFindOrDelete.Text);

            if (checkValue == 1)
            {
                ConnectToDataBase db = new ConnectToDataBase();
                try
                {
                    db.Employees.RemoveRange(db.Employees.Where(x => x.Name == textBoxFindOrDelete.Text));
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Data is not delete.", "Message");
                }
            }
            else
            {
                MessageBox.Show("Information not found.", "Message");
            }
        }
    }
}