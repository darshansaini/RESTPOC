using Microsoft.EntityFrameworkCore;
using RESTPOC1.Models;
namespace RESTPOC1.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
