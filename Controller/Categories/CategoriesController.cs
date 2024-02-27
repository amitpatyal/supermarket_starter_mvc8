using Microsoft.AspNetCore.Mvc;
using supermarket_starter_mvc8.Model.Category;

namespace supermarket_starter_mvc8.Controllers.Categories
{
  public class CategoriesController : Controller
  {
    public IActionResult Index()
    {
      var categories = CategoriesRepository.GetAllCategories();
      return View(categories);
    }

    [HttpGet]
    public IActionResult Add()
    {
      ViewBag.Action = "Add";
      return View();
    }

    [HttpPost]
    public IActionResult Add(Category category) {
      ViewBag.Action = "Add";
      if (ModelState.IsValid) {
        CategoriesRepository.AddCategory(category);
        return RedirectToAction(nameof(Index));
      }
      return View(category);
    }

    [HttpGet]
    public IActionResult Edit(int? id) {
      ViewBag.Action = "Edit";
      var category = CategoriesRepository.GetCategoryById(id.HasValue ? id.Value : 0);
      return View(category);
    }

    [HttpPost]
    public IActionResult Edit(Category category) {
      ViewBag.Action = "Edit";
      if (ModelState.IsValid)
      {
        CategoriesRepository.UpdateCategoryById(category);
        return RedirectToAction(nameof(Index));
      }
      return View(category);
    }

    public IActionResult Delete(int id)
    {
      CategoriesRepository.RemoveCategoryById(id);
      return RedirectToAction(nameof(Index));
    }
  }
}
