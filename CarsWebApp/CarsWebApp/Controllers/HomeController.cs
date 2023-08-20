using Microsoft.AspNetCore.Mvc;

namespace CarsWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
