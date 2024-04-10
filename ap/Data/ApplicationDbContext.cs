
using Microsoft.EntityFrameworkCore;
namespace ap.Data
{
    public class ApplicationDbContext:DbContext 
    {
        public DbSet<model.Category> category { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
         
        }


    }
}
