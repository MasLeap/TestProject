using EmployeeAPI.Models;

namespace EmployeeAPI.Data
{
    public class EmployeeRepository : Repository<Employee>
    {
        public EmployeeRepository(EmployeeAPIContext context) : base(context)
        {

        }
    }
}
