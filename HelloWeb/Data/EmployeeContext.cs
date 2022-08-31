using HelloWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWeb.Data
{
    public class EmployeeContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=EmployeeDb;"
            + "Integrated Security=true");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
