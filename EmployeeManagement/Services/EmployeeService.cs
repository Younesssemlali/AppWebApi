using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeManagementDbContext _employeeManagementDbContext;
        public EmployeeService(EmployeeManagementDbContext employeeManagementDbContext)
        {
            _employeeManagementDbContext = employeeManagementDbContext;
        }

        public void AddEmployee(Employee employee)
        {
            _employeeManagementDbContext.employees.Add(employee);
            _employeeManagementDbContext.SaveChanges();
        }

        public Employee DeleteEmployee(int id)
        {
            var employee = GetById(id);
            _employeeManagementDbContext.employees.Remove(employee);
            _employeeManagementDbContext.SaveChanges();
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeManagementDbContext.employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _employeeManagementDbContext.employees.Find(id);

        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeManagementDbContext.Entry(employee).State =.EntityState.Modified;
            _employeeManagementDbContext.SaveChanges(); }
    }
}
