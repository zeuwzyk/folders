using System.Linq;
using System.Windows.Forms;

namespace EmployeeDataBase.Helpers
{
    public static class DataBaseManager
    {
        public static void OpenDB(DataGridView employeeGridView)
        {
            using (DataBaseOpenSave db = new DataBaseOpenSave())
            {
                var employee = db.Employees.ToList();

                foreach (DataEmployee de in employee)
                {
                    GridHelper.FillingGrid(employeeGridView, de.Id, de.Name, de.Age, de.Car);
                }
            }
        }

        public static void SaveDB(DataGridView employeeGridView, string nameEmployee, int ageEmployee, string carEmployee)
        {
            int idEmployee;

            using (DataBaseOpenSave db = new DataBaseOpenSave())
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

                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }

        public static void DeleteFromBD(TextBox textBoxFindOrDelete)
        {
            using (DataBaseOpenSave db = new DataBaseOpenSave())
            {
                db.Employees.RemoveRange(db.Employees.Where(x => x.Name == textBoxFindOrDelete.Text));
                db.SaveChanges();
            }
        }
    }
}
