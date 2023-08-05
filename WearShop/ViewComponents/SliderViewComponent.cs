using Microsoft.AspNetCore.Mvc;
using WearShop.Contracts;

namespace WearShop.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly ISliderRepository _repository;
        public SliderViewComponent(ISliderRepository repository)
        {
            _repository = repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var slide = await _repository.AllSlide();
            return View("Slider", slide);
        }
    }
}
