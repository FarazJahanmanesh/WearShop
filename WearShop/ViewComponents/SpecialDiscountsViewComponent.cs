using Microsoft.AspNetCore.Mvc;
using WearShop.Contracts;

namespace WearShop.ViewComponents
{
	public class SpecialDiscountsViewComponent:ViewComponent
	{
		private readonly IProductRepository _repository;
		public SpecialDiscountsViewComponent(IProductRepository repository)
		{
			_repository = repository;
        }
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var product = await _repository.SpecialDiscounts();
            return View("SpecialDiscounts", product);
		}
	}
}
