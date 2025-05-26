using EmployeesApp.Application;
using EmployeesApp.Infrastructure;


public class Program
{
    public static void Main(string[] args)
    {
        IEmployeeRepository repository = new EmployeeRepository();
        EmployeeService service = new EmployeeService(repository);

        //foreach (var item in service.GetAll())
        //{
        //    Console.WriteLine(item.Name);
        //}
        Console.WriteLine("enter id");
        try
        {
            int input = int.Parse(Console.ReadLine());
            var ret = service.GetById(input);
            Console.WriteLine(ret.Name);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}