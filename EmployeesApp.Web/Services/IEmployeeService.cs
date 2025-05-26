using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public interface IEmployeeService
    {
        void Add(Employee employee);

        Employee[] GetAll();

        Employee GetById(int id);

        public bool CheckIsVIP(Employee employee);
    }
}
