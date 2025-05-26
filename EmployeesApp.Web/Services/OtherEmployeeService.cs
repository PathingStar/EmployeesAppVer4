using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public class OtherEmployeeService : IEmployeeService
    {
        readonly List<Employee> employees =
        [
            new Employee()
            {
                Id = 1000,
                Name = "Karl XII",
                Email = "karl.xii@outlook.com",
            },
            new Employee()
            {
                Id = 2002,
                Name = "Drottning Kristina",
                Email = "admin.drottning kristina@outlook.com",
            },
            new Employee()
            {
                Id = 4400,
                Name = "Gustav III",
                Email = "gustav.iii@outlook.com",
            },
            new Employee()
            {
                Id = 3030,
                Name = "Margareta Valdemarsdotter",
                Email = "margareta.valdemarsdotter@outlook.com",
            },
            new Employee()
            {
                Id = 5555,
                Name = "Gustav Vasa",
                Email = "gustav.vasa@outlook.com",
            },
        ];

        public void Add(Employee employee)
        {
            employee.Id = employees.Count < 0 ? 1 : employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }


        // Collection expression syntax, introduced in C# 12.
        public Employee[] GetAll() => [.. employees.OrderBy(e => e.Name)];

        ////Classic C# syntax for GetAll()
        //public Employee[] GetAll()
        //{
        //    return employees
        //        .OrderBy(e => e.Name)
        //        .ToArray();
        //}

        public Employee GetById(int id) => employees
            .Single(e => e.Id == id);

        public bool CheckIsVIP(Employee employee) =>
            employee.Email.StartsWith("ADMIN", StringComparison.CurrentCultureIgnoreCase);
    }
}