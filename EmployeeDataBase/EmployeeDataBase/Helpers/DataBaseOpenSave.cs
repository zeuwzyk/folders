using Microsoft.EntityFrameworkCore;

namespace EmployeeDataBase.Helpers
{
    public partial class DataBaseOpenSave : DbContext
    {
        public DataBaseOpenSave()
        {
            Database.EnsureCreated();
        }

        public DataBaseOpenSave(DbContextOptions<DataBaseOpenSave> options) : base(options)
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
           // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}