using HRM.Web.Data;
using HRM.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure.Repositories
{
    public class DepartmentRepository
    {
        private readonly EmployeeContext db;
        public DepartmentRepository(EmployeeContext employeeContext)
        {
            db = employeeContext;
        }

        public async Task<List<Department>> GetAll()
        {
            var departments = db.Departments.ToList();
            return departments;
        }
    }
}
