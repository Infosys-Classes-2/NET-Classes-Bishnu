using HRM.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRM.Web.Data
{
    public class EmployeeContext: IdentityDbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> dbContextOptions): 
            base(dbContextOptions)
        {            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Admin" },
                new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "HR" }
                );
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
    }
}
