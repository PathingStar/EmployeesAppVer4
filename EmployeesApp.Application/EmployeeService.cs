using EmployeesApp.Domain;
using EmployeesApp.Infrastructure;

namespace EmployeesApp.Application;

public class EmployeeService(IEmployeeRepository repository) : IEmployeeService
{

    public void Add(Employee employee)
    {
        repository.Add(employee);
    }


    // Collection expression syntax, introduced in C# 12.
    public Employee[] GetAll() => repository.GetAll();

    ////Classic C# syntax for GetAll()
    //public Employee[] GetAll()
    //{
    //    return employees
    //        .OrderBy(e => e.Name)
    //        .ToArray();
    //}

    public Employee GetById(int id) => repository.GetById(id);
    public bool CheckIsVIP(Employee employee) =>
        employee.Email.StartsWith("ADMIN", StringComparison.CurrentCultureIgnoreCase);
}