using WearShop.Models;

namespace WearShop.Contracts
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> ReadAllCategory();
    }
}
