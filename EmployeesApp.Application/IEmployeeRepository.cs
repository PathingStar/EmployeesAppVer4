using EmployeesApp.Domain;

namespace EmployeesApp.Infrastructure;
public interface IEmployeeRepository
{
    void Add(Employee employee);
    Employee[] GetAll();
    Employee GetById(int id);
}