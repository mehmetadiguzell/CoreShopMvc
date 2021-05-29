using CoreShopMvc.Repositories.EntityFramework.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreShopMvc.ViewComponents
{
    public class ProductList : ViewComponent
    {
        IProductRepository _porductRepository;
        public ProductList(IProductRepository productRepository)
        {
            _porductRepository = productRepository;
        }
        public IViewComponentResult Invoke(int? categoryId)
        {
            if (categoryId.HasValue)
            {
                var categoryList = _porductRepository.CategoryList((int)categoryId);
                return View(categoryList);
            }
            var allCategory = _porductRepository.GetAll(c => c.Status == true);
            return View(allCategory);
        }
    }
}
