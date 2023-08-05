using WearShop.Models;

namespace WearShop.Contracts
{
    public interface ISliderRepository
    {
        public Task<List<Slider>> AllSlide();
    }
}
