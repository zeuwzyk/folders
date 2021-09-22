using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDataBase
{
    public partial class DataBaseSave : DbContext
    {


            public DataBaseSave(DbContextOptions<DataBaseSave> options) : base(options)
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
            public DataBaseSave()
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                OnModelCreatingPartial(modelBuilder);
            }

            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        }
    }
