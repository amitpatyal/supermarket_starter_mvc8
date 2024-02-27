using Microsoft.AspNetCore.Mvc;

namespace supermarket_starter_mvc8.Controllers.Home
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
