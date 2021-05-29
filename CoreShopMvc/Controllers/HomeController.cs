using CoreShopMvc.Repositories.EntityFramework.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreShopMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index(int? categoryId)
        {
            ViewBag.CategoryId = categoryId;
            return View();
        }

        public IActionResult ProductDetails(int id = 0)
        {
            var result = _productRepository.Get(c => c.ProductId == id);
            ViewBag.categoryName = _productRepository.CategoryName(result.CategoryId);
            return View(result);
        }

    }
}
