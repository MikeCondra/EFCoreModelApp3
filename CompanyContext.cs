using Microsoft.EntityFrameworkCore;
using EFCoreModelApp3.Models;

namespace EFCoreModelApp3
{
    public class CompanyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CompanyDB.db");
        }
    }
}