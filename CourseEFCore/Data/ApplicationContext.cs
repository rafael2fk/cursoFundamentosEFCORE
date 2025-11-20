using Microsoft.EntityFrameworkCore;

namespace CourseEFCore.Data
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CourseEFCore;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
