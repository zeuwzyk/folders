using System.Collections.Generic;
using WebApplicationResources.Entities.Models;

namespace WebApplicationResources.Managers
{
    public interface IEmployeeManager
    {
        IEnumerable<EmployeeData> GetEmployee();

        EmployeeData PostEmployee(EmployeeData employeeData);

        EmployeeData DeleteEmployee(int id);
    }
}
