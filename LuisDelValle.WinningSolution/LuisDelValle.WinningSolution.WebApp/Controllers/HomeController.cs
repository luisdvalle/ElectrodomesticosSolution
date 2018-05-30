using Microsoft.AspNetCore.Mvc;

namespace LuisDelValle.WinningSolution.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}