using Microsoft.EntityFrameworkCore;
using WearShop.Contracts;
using WearShop.Models;

namespace WearShop.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly WearShopDbContext _context;

        public CategoryRepository(WearShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> ReadAllCategory()
        {
            return await _context.Categories.AsNoTracking().ToListAsync();
        }
    }
}
