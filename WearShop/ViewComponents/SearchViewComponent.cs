using Microsoft.AspNetCore.Mvc;
using WearShop.Contracts;

namespace WearShop.ViewComponents
{
	public class SearchViewComponent:ViewComponent
	{
		private readonly IProductRepository _repository;
        public SearchViewComponent(IProductRepository repository)
		{
			_repository = repository;
		}
        public async Task<IViewComponentResult> InvokeAsync(string name)
        {
            var Products = await _repository.SearchForProduct(name);
            return View();
        }
    }
}
