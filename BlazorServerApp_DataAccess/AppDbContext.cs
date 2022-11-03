using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp_DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // creates a table in the database
        // public DbSet<Domain>Domains { get; set; }
    }
}