global using Microsoft.EntityFrameworkCore;
using firstWebApi.Entity;

namespace firstWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Items> items { get; set; }
    }
}
