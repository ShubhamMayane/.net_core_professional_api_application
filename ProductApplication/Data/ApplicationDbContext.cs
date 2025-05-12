using Microsoft.EntityFrameworkCore;
using ProductApplication.Models.Entities;


namespace ProductApplication.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
     : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
