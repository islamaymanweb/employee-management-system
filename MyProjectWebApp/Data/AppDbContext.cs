using Microsoft.EntityFrameworkCore;
using MyProjectWebApp.Models;
using System.Collections.Generic;

namespace MyProjectWebApp.Data
{
    public class AppDbContext: DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

            //DbSet properties
            public DbSet<Department> Departments { get; set; }
            public DbSet<Employee> Employees { get; set; }
    }
}
