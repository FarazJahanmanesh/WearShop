using Microsoft.AspNetCore.Mvc;
using WearShop.Contracts;
using WearShop.Repository;

namespace WearShop.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _repository;
        public MenuViewComponent(ICategoryRepository repository)
        {
            _repository = repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Categories = await _repository.ReadAllCategory();
            return View("Menu", Categories);
        }
    }
}
