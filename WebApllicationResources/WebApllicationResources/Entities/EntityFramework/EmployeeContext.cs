using Microsoft.EntityFrameworkCore;
using WebApplicationResources.Entities.Models;

namespace WebApplicationResources.Entities.EntityFramework
{
    public class EmployeeContext : DbContext
    {
        public DbSet<EmployeeData> Employee { get; set; }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}