using Microsoft.EntityFrameworkCore;

namespace WebAzure.Models
{
    public class HRContext : DbContext{

        public HRContext(DbContextOptions<HRContext> options) : base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}