using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Models
{
    public class YourContext : DbContext
    {
        public YourContext(DbContextOptions<YourContext> options) : base(options) { }

        public DbSet<Dish> Dishes { get; set; }

    }
}