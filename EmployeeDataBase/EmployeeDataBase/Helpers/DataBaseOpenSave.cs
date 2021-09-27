using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace EmployeeDataBase.Helpers
{
    public partial class DataBaseOpenSave : DbContext
    {
        public DataBaseOpenSave()
        {
            Database.EnsureCreated();
        }

        public DataBaseOpenSave(DbContextOptions<DataBaseOpenSave> options) : base(options)
        { }

        public virtual DbSet<DataEmployee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DataBaseOpenSave"].ConnectionString;

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}