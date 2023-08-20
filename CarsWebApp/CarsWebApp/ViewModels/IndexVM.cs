using CarsWebApp.Models;

namespace CarsWebApp.ViewModels
{
    public class IndexVM
    {
        public List<Series> SeriesList { get; set; }
        public List<Car> Cars { get; set; }
        public string Name { get; set; }
        public string SeriesName { get; set; }
    }
}