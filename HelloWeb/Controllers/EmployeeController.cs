using Microsoft.AspNetCore.Mvc;
using HelloWeb.Models;

namespace HelloWeb.Controllers;

public class EmployeeController : Controller
{
    // employee/list
    public IActionResult List()
    {
        Employee employee1 = new()
        {
            FirstName = "Ram",
            LastName = "Basnet",
            Designation = "Sotware Engineer",
            Level = 7,
            Department = "R&D1",
            JoinDate = DateTime.Now
        };

        Employee employee2 = new()
        {
            FirstName = "Jenny",
            LastName = "Maharjan",
            Designation = "Sr. Sotware Engineer",
            Level = 7,
            Department = "R&D2",
            JoinDate = DateTime.Now
        };

        List<Employee> employees = new() { employee1, employee2 };

        return View(employees);
    }
}
