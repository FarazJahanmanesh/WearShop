using WearShop.Models;

namespace WearShop.Contracts
{
    public interface IProductRepository
    {
        public Task<List<Product>> SearchForProduct(string name);
        public Task<List<Product>> ShowTheLatestProducts(int skip, int take);
        public Task<List<Product>> SpecialDiscounts();
        public Task<Product> ShowProduct(int id);
    }
}
