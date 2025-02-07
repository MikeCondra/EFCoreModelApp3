namespace EFCoreModelApp3.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; } = "";
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}