using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetById(int id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        Employee DeleteEmployee(int id);
    }
}
