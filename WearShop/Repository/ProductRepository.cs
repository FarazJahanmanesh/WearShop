using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WearShop.Contracts;
using WearShop.Models;

namespace WearShop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly WearShopDbContext _context;

        public ProductRepository(WearShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> SearchForProduct(string name)
        {
            return await _context.Products.Where(c => c.Title.Contains(name))
                .ToListAsync();
        }
        public async Task<List<Product>> ShowTheLatestProducts(int skip , int take)
        {
            return await _context.Products.AsNoTracking()
                .OrderByDescending(x => x.CreateDate)
                .Skip(skip).Take(take).ToListAsync();
        }
        public async Task<List<Product>> SpecialDiscounts()
        {
            return await _context.Products.AsNoTracking()
                .OrderByDescending(c => c.Off).Skip(0).Take(4)
                .ToListAsync();
        }
        public async Task<Product> ShowProduct(int id)
        {
            return await _context.Products.AsNoTracking()
                .Include(x=>x.comments.Where(c=>c.IsActive==true))
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
