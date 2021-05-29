using CoreShopMvc.Data.Models;
using CoreShopMvc.Repositories.EntityFramework.Abstract;

namespace CoreShopMvc.Repositories.EntityFramework.Concrete
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
    }
}
