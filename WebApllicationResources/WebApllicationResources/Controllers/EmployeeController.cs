using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationResources.Entities.Models;
using WebApplicationResources.Managers;

namespace WebApplicationResources.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager _employeeManager;

        public EmployeeController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeData>> Get()
        {
            var list = _employeeManager.GetEmployee();

            return new JsonResult(list);
        }

        [HttpPost]
        public ActionResult<EmployeeData> Post([FromForm] EmployeeData employeeData)
        {
            var emplData = _employeeManager.PostEmployee(employeeData);

            return Ok(emplData);
        }

        [HttpDelete("{id}")]
        public EmployeeData Delete(int id)
        {
            return _employeeManager.DeleteEmployee(id);
        }
    }
}