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

        public async Task<List<Department>> GetAllAsync()
        {
            var departments = db.Departments.ToList();
            return departments;
        }

        public async Task<Department> GetAsync(int id) =>
            await db.Departments.FindAsync(id);

        public async Task<int> InsertAsync(Department department)
        {
            await db.Departments.AddAsync(department);
            return await CommitAsync();
        }

        public async Task<int> EditAsync(Department department)
        {
            db.Departments.Update(department);
            return await CommitAsync();
        }

        public async Task<int> DeleteAsync(Department department)
        {
            db.Departments.Remove(department);
            return await CommitAsync();
        }

        public async Task<int> CommitAsync()
        {
            var rowsAffected = await db.SaveChangesAsync();
            return rowsAffected;
        }
    }
}
