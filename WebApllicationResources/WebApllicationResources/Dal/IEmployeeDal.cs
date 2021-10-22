using System.Collections.Generic;
using WebApplicationResources.Entities.Models;

namespace WebApplicationResources.Dal
{
    public interface IEmployeeDal
    {
        IEnumerable<EmployeeData> GetEmployee();

        EmployeeData PostEmployee(EmployeeData employeeData);

        EmployeeData DeleteEmployee(int id);
    }
}
