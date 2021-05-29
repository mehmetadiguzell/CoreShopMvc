using CoreShopMvc.Repositories.EntityFramework.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreShopMvc.ViewComponents
{
    public class CategoryList : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryList(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var result = _categoryRepository.GetAll(c => c.Status == true);
            return View(result);
        }
    }
}
