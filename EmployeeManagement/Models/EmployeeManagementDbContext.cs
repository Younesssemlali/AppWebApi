using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class EmployeeManagementDbContext:DbContext
    {
        public EmployeeManagementDbContext(DbContextOptions<EmployeeManagementDbContext> options):base(options)
        {
                
        }
        public DbSet<Employee>  employees { get; set; }
    }
}
