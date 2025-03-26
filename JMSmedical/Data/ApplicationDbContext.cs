using JMSmedical.Models;
using Microsoft.EntityFrameworkCore;

namespace JMSmedical.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // ✅ Ensure this line exists
        public DbSet<Product> Products { get; set; }
    }
}
