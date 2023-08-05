using Microsoft.EntityFrameworkCore;
using WearShop.Contracts;
using WearShop.Models;

namespace WearShop.Repository
{
    public class SliderRepository: ISliderRepository
    {
        private readonly WearShopDbContext _context;

        public SliderRepository(WearShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<Slider>> AllSlide()
        {
            return await _context.Sliders.AsNoTracking().ToListAsync();
        }
    }
}
