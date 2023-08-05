using Microsoft.EntityFrameworkCore;

namespace WearShop.Models
{
    public class WearShopDbContext : DbContext
    {
        public WearShopDbContext(DbContextOptions<WearShopDbContext> option) : base(option)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}