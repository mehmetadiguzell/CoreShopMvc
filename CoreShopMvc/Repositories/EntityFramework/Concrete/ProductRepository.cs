using CoreShopMvc.Data.Models;
using CoreShopMvc.Repositories.EntityFramework.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoreShopMvc.Repositories.EntityFramework.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public List<Product> CategoryList(int categoryId)
        {
            using var context = new Context();
            return context.Products.Where(c => c.CategoryId == categoryId && c.Status==true).ToList();
        }

        public string CategoryName(int categoryId)
        {
            using var context = new Context();
            return context.Categories.Where(c => c.Id == categoryId).Select(c => c.Name).FirstOrDefault();
        }

        public List<Product> Include(string table)
        {
            using var context = new Context();
            return context.Products.Include(table).ToList();

        }
    }
}
