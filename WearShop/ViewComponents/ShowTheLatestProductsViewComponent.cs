using Microsoft.AspNetCore.Mvc;
using WearShop.Contracts;

namespace WearShop.ViewComponents
{
    public class ShowTheLatestProductsViewComponent : ViewComponent
    {
        private readonly IProductRepository _repository;
        public ShowTheLatestProductsViewComponent(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _repository.ShowTheLatestProducts(0,8);
            return View("ShowTheLatestProducts", products);
        }
    }
}
