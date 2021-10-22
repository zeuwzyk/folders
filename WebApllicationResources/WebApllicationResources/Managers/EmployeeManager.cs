using System.Collections.Generic;
using WebApplicationResources.Dal;
using WebApplicationResources.Entities.Models;

namespace WebApplicationResources.Managers
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IEnumerable<EmployeeData> GetEmployee()
        {
            return _employeeDal.GetEmployee();
        }

        public EmployeeData PostEmployee(EmployeeData employeeData)
        {
            return _employeeDal.PostEmployee(employeeData);
        }

        public EmployeeData DeleteEmployee(int id)
        {
            return _employeeDal.DeleteEmployee(id);
        }
    }
}
