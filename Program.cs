// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;
using EFCoreModelApp3.Models;

namespace EFCoreModelApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new CompanyContext();

            var department = new Department { Name = "Engineering" };

            context.Departments.Add(
                new Department
                {
                    Name = "Engineering",
                    Employees = new List<Employee>
                {
                    new Employee
                    {
                        FirstName = "Marissa",
                        LastName = "Johanssen",
                        HireDate = DateTime.Now
                    },
                    new Employee
                    {
                        FirstName = "Ryan",
                        LastName = "Ford",
                        HireDate = DateTime.Now
                    }
                }
                });

            context.SaveChanges();

            var employees = context.Employees.Where(e => e.Department != null && e.Department.Name == "Engineering").ToList();
            Console.WriteLine($"Employees in Engineering:  {employees.Count}");
        }
    }
}

