﻿using HRM.Web.Data;
using HRM.Web.Mapper;
using HRM.Web.Models;
using HRM.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace HRM.Web.Controllers;

public class EmployeeController : Controller
{
    // Tightly coupled code
    private readonly EmployeeContext db;

    // Dependency injection (DI), built-in
    public EmployeeController(EmployeeContext _db)
    {
        db = _db;
    }

    [HttpGet]
    public async Task<IActionResult> List(string searchText)
    {
        var employees = await db.Employees
            .Where(e => e.Active.Value && (string.IsNullOrEmpty(searchText)  //Short-circuit
                    || e.FirstName.Contains(searchText) 
                    || e.LastName.Contains(searchText)))
            .Include(x => x.Department)
            .Include(y => y.Designation).ToListAsync();

        return View(employees.ToViewModel());
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {
        var departments = await db.Departments.ToListAsync();
        ViewData["Departments"] = departments.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString()
        });
        var designations = await db.Designations.ToListAsync();
        ViewData["Designations"] = designations.Select(x => new SelectListItem()
        {
            Text = x.Title,
            Value = x.Id.ToString()
        });

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(EmployeeViewModel employeeViewModel)
    {
        employeeViewModel.ProfileImage = SaveProfileImage(employeeViewModel.Avatar);
        employeeViewModel.Active = true;

        var emp = employeeViewModel.ToModel();

        await db.Employees.AddAsync(emp);
        await db.SaveChangesAsync();

        return RedirectToAction(nameof(List));
    }

    public async Task<IActionResult> Edit(int id)
    {
        var departments = await db.Departments.ToListAsync();
        ViewData["Departments"] = departments.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString()
        });

        var designations = await db.Designations.ToListAsync();
        ViewData["Designations"] = designations.Select(x => new SelectListItem()
        {
            Text = x.Title,
            Value = x.Id.ToString()
        });

        var employee = await db.Employees.FindAsync(id);

        return View(employee.ToViewModel());
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EmployeeViewModel employeeViewModel)
    {
        if (employeeViewModel.Avatar is not null)
        {
            employeeViewModel.ProfileImage = SaveProfileImage(employeeViewModel.Avatar);
        }
        var emp = employeeViewModel.ToModel();

        db.Employees.Update(emp);
        await db.SaveChangesAsync();

        return RedirectToAction(nameof(List));
    }

    public IActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(Employee emp)
    {
        //db.Employees.Remove(emp);
        var employee = await db.Employees.FindAsync(emp.Id);

        employee.Active = false;

        db.SaveChanges();

        return RedirectToAction(nameof(List));
    }

    private string SaveProfileImage(IFormFile avatar)
    {
        // Save profile image to "profile-images" folder        
        var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "profile-images");

        Directory.CreateDirectory(folderPath);

        var uniqueImageName = $"{Guid.NewGuid():D}_{avatar.FileName}";
        var filePath = Path.Combine(folderPath, uniqueImageName);

        using FileStream fileStream = new(filePath, FileMode.Create);
        avatar.CopyTo(fileStream);

        return uniqueImageName;
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
            SqlCommand command = new(queryString, connection);

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
