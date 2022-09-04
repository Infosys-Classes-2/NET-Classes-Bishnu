namespace HelloWeb.Models;
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Designation { get; set; }
    public byte Level { get; set; }
    public DateTime JoinDate { get; set; }

    // One employee has only one department, department has multiple employees
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}
