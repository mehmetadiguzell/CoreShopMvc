using CoreShopMvc.Data.Models;
using CoreShopMvc.Repositories.EntityFramework.Abstract;
using CoreShopMvc.Repositories.EntityFramework.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;


namespace CoreShopMvc.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var result = _productRepository.Include("Category");
            return View(result);
        }
        public IActionResult Add()
        {
            using var context = new Context();
            List<SelectListItem> categoryList = (from i in context.Categories.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = i.Name,
                                                     Value = i.Id.ToString()
                                                 }).ToList();
            ViewBag.CategoryList = categoryList;
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product entity)
        {
            _productRepository.Add(entity);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id = 0)
        {
            using var context = new Context();
            List<SelectListItem> categoryList = (from i in context.Categories.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = i.Name,
                                                     Value = i.Id.ToString()
                                                 }).ToList();
            ViewBag.CategoryList = categoryList;
            var result = _productRepository.Get(c => c.ProductId == id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Product entity)
        {
            _productRepository.Update(entity);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id = 0)
        {
            var result = _productRepository.Get(c => c.ProductId == id);
            _productRepository.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
