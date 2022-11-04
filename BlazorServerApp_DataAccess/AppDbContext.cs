
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp_DataAccess
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // creates a table in the database
        // public DbSet<Domain>Domains { get; set; }

       public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}