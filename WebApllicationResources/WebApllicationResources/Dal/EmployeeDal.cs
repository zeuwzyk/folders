using System.Collections.Generic;
using System.Linq;
using WebApplicationResources.Entities.EntityFramework;
using WebApplicationResources.Entities.Models;

namespace WebApplicationResources.Dal
{
    public class EmployeeDal : IEmployeeDal
    {
        private readonly EmployeeContext db;

        public EmployeeDal(EmployeeContext context)
        {
            db = context;
        }

        public IEnumerable<EmployeeData> GetEmployee()
        {
            return db.Employee;
        }

        public EmployeeData PostEmployee(EmployeeData employeeData)
        {
            var emplData = db.Employee.Add(employeeData);
            db.SaveChanges();

            return (emplData).Entity;
        }

        public EmployeeData DeleteEmployee(int id)
        {
            //try
            //{
                EmployeeData employeeData = db.Employee.First(x => x.Id == id);

                var emplData = db.Employee.Remove(employeeData);
                db.SaveChanges();

                return emplData.Entity;
                //}
                //catch (Exception e)
                //{
                //    //Nlog Logger.LogException(e)
                //    return false
                //}


        }
    }
}
