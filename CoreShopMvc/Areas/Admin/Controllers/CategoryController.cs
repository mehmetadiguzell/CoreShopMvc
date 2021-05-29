using CoreShopMvc.Data.Models;
using CoreShopMvc.Repositories.EntityFramework.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreShopMvc.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var result = _categoryRepository.GetAll();
            return View(result);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category entity)
        {
            _categoryRepository.Add(entity);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id = 0)
        {
            var result = _categoryRepository.Get(c => c.Id == id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Category entity)
        {
            _categoryRepository.Update(entity);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id = 0)
        {
            var result = _categoryRepository.Get(c => c.Id == id);
            _categoryRepository.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
