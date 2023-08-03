using Microsoft.EntityFrameworkCore;

namespace MVC_D2.Models
{
   
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-KI2HE27\\MAHMOUD ;Database=STG1_MVC_D2;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Employee> employee { get; set; }
        public DbSet<Project> project { get; set; }
        public DbSet<Office> office { get; set; }
        public DbSet<Emp_proj> emp_proj { get; set;}
        
    }
}
