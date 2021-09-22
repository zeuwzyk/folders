using Microsoft.EntityFrameworkCore;

namespace EmployeeDataBase
{
    public partial class DataBaseManager : DbContext
    {
        public DataBaseManager()
        {
            Database.EnsureCreated();//может стирать
        }

        public DataBaseManager(DbContextOptions<DataBaseManager> options) : base(options)
        {
        }

        public virtual DbSet<DataEmployee> Employees { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=employeedb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}