using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Data
{
    public class EmployeeAPIContext : DbContext
    {
        public EmployeeAPIContext (DbContextOptions<EmployeeAPIContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeAPI.Models.Employee> Employee { get; set; }
    }
}
