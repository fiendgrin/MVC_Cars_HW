using Microsoft.AspNetCore.Mvc;
using CarsWebApp.Models;
using CarsWebApp.ViewModels;

namespace CarsWebApp.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _cars;

        public CarController()
        {
            _cars = new List<Car>()
            {
                new Car { Id = 1,SeriesId=1,BrandId=1,Name="Boxter",Color="Blue"},
                new Car { Id = 2,SeriesId=1,BrandId=1,Name="Cayman S",Color="Yellow"},
                new Car { Id = 3,SeriesId=2,BrandId=1,Name="Carrera",Color="Red"},
                new Car { Id = 4,SeriesId=2,BrandId=1,Name="Turbo",Color="Black"},
                new Car { Id = 5,SeriesId=3,BrandId=2,Name="850i xdrive Gran Coupe",Color="Dark-Blue"},
                new Car { Id = 6,SeriesId=3,BrandId=2,Name="Competition Convertible",Color="Dark-Green"},
                new Car { Id = 7,SeriesId=4,BrandId=2,Name="530i xDrive",Color="White"},
                new Car { Id = 8,SeriesId=4,BrandId=2,Name="F90",Color="White"},
                new Car { Id = 9,SeriesId=5,BrandId=3,Name="R-34",Color="Blue"},
                new Car { Id = 10,SeriesId=5,BrandId=3,Name="R-35",Color="Matte-Grey"},
                new Car { Id = 11,SeriesId=6,BrandId=3,Name="34",Color="Yellow"},
                new Car { Id = 12,SeriesId=6,BrandId=3,Name="31",Color="Grey"},
            };
        }
        public IActionResult Index(int? id, string BrandName, string SeriesName)
        {
            if (id == null) return BadRequest("Series Id is required");
            if (!_cars.Exists(car => car.SeriesId==id)) return NotFound($"{id} is not an existing Series Id");

            IndexVM indexVM2 = new IndexVM();

            indexVM2.Cars = _cars.FindAll(car => car.SeriesId==id);
            indexVM2.SeriesName = SeriesName;
            indexVM2.Name = BrandName;
            return View(indexVM2);
        }
    }
}
