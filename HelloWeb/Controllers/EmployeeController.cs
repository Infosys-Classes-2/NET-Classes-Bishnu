using HelloWeb.Data;
using HelloWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HelloWeb.Controllers;

public class EmployeeController : Controller
{
    EmployeeContext db = new();

    [HttpGet]
    public IActionResult List()
    {   
        var employees = db.Employees.ToList();

        return View(employees);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Employee emp)  
    {        
        db.Employees.Add(emp);
        db.SaveChanges();

        return RedirectToAction(nameof(List));
    }

    public IActionResult Edit(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Edit(Employee emp)
    {
        db.Employees.Update(emp);
        db.SaveChanges();

        return RedirectToAction(nameof(List));
    }

    public IActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Delete(Employee emp)
    {
        db.Employees.Remove(emp);
        db.SaveChanges();

        return RedirectToAction(nameof(List));
    }

    // Using ADO.NET
    public void GetPeople()
    {
        // Using ADO.NET
        string connectionString =
            @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=TestDb;"
            + "Integrated Security=true";

        string queryString = "SELECT * from person";
        
        using (SqlConnection connection = new(connectionString))
        {
            // Create the Command and Parameter objects.
            SqlCommand command = new (queryString, connection);

            // Open the connection in a try/catch block.
            // Create and execute the DataReader, writing the result
            // set to the console window.
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",
                        reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
