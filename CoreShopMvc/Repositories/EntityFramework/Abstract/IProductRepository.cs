using CoreShopMvc.Data.Models;
using System.Collections.Generic;

namespace CoreShopMvc.Repositories.EntityFramework.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> Include(string table);
        List<Product> CategoryList(int categoryId);
        string CategoryName(int categoryId);
    }
}
