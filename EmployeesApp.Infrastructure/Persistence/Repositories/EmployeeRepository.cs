using EmployeesApp.Application;
using EmployeesApp.Domain;

namespace EmployeesApp.Infrastructure;

public class EmployeeRepository : IEmployeeRepository
{
    public List<Employee> employees =
    [
        new Employee()
        {
            Id = 562,
            Name = "Anders Hejlsberg",
            Email = "Anders.Hejlsberg@outlook.com",
        },
        new Employee()
        {
            Id = 562,
            Name = "Anders Hejlsberg",
            Email = "Anders.Hejlsberg@outlook.com",
        },
        new Employee()
        {
            Id = 62,
            Name = "Kathleen Dollard",
            Email = "k.d@outlook.com",
        },
        new Employee()
        {
            Id = 15662,
            Name = "Mads Torgersen",
            Email = "Admin.Torgersen@outlook.com",
        },
        new Employee()
        {
            Id = 52,
            Name = "Scott Hanselman",
            Email = "s.h@outlook.com",
        },
        new Employee()
        {
            Id = 563,
            Name = "Jon Skeet",
            Email = "j.s@outlook.com",
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

    public Employee GetById(int id)
    {
        Employee employee;
        try
        {
             employee = employees
            .SingleOrDefault(e => e.Id == id);
            
        }
        catch (InvalidOperationException ex)
        {
            throw new Exception($"More then one Employee have ID:{id}!", ex);
        }
        if (employee == null)
            throw new Exception($"Employee with ID:{id} not found!");
        return employee;
        //if (employee == null)
        //throw new Exception("employee not found!");


    }


}