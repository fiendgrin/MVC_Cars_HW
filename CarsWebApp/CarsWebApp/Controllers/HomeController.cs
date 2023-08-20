using Microsoft.AspNetCore.Mvc;
using CarsWebApp.Models;

namespace CarsWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Brand> _brands;

        public HomeController()
        {
            _brands = new List<Brand>() {
                new Brand{Id=1,Name="Porsche",Manufacturer="Germany",Foundation=1948},
                new Brand{Id=2,Name="BMW",Manufacturer="Germany",Foundation=1916},
                new Brand{Id=3,Name="Nissan",Manufacturer="Japan",Foundation=1933},
            };
        }
        public IActionResult Index()
        {
            return View(_brands);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return BadRequest("Brand Id is required");

            if (!_brands.Exists(brand => brand.Id == id)) return NotFound($"{id} is not an existing Brand Id");

            return View(_brands.Find(brand => brand.Id == id));
        }

    }
}