using CarsWebApp.Models;

namespace CarsWebApp.ViewModels
{
    public class IndexVM
    {
        public Brand Brands { get; set; }

        public List<Series> SeriesList { get; set; }

        public string Name { get; set; }
    }
}