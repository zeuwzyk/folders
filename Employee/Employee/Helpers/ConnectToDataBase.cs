using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Windows.Forms;

namespace Employee.Helpers
{
    public class ConnectToDataBase : DbContext
    {
        public ConnectToDataBase()
        {
            Database.EnsureCreated();
        }

        public ConnectToDataBase(DbContextOptions<ConnectToDataBase> options) : base(options)
        { }

        public virtual DbSet<DataEmployee> Employees { get; set; }

        public static int countRowsSQL;
        public static int countRowsConfig;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["ConnectToDataBase"].ConnectionString;
                countRowsConfig = int.Parse(ConfigurationManager.AppSettings["NumberRows"]);

                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(connectionString);
                }

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Employees", con);

                con.Open();
                cmd.CommandText = "SELECT COUNT(*) FROM Employees";
                countRowsSQL = (int)cmd.ExecuteScalar();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Database is not found. Database will be created.", "Message");
            }
        }

        public static int ReturnNumberRowsSQl()
        {
            return countRowsSQL;
        }

        public static int ReturnNumberRowsConfig()
        {
            return countRowsConfig;
        }
    }
}