using ContactWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactWebApi.Data
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext(DbContextOptions<EmployeesContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
    }
}
