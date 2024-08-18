using data_store_system.Models;
using Microsoft.EntityFrameworkCore;

namespace data_store_system.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set;}
    }
}
