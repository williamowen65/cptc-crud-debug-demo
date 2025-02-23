using Microsoft.EntityFrameworkCore;

namespace CPW219_CRUD_Troubleshooting.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = The desired name for the database
            // Server = The server we are connecting to. LocalDB is included with Visual Studio
            // Trusted_Connection = True means we are using Windows Authentication
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=cptc-crud-bug-demo;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
