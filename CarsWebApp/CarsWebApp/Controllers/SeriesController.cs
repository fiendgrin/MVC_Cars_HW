using Microsoft.AspNetCore.Mvc;
using CarsWebApp.Models;
using CarsWebApp.ViewModels;
using System;

namespace CarsWebApp.Controllers
{
    public class SeriesController : Controller
    {
        private readonly List<Series> _series;

        public SeriesController()
        {
            _series = new List<Series>() {
                new Series() {Id=1,BrandId=1,Name="718 Series"},
                new Series() {Id=2,BrandId=1,Name="911 Series"},
                new Series() {Id=3,BrandId=2,Name="8 Series"},
                new Series() {Id=4,BrandId=2,Name="5 Series"},
                new Series() {Id=5,BrandId=3,Name="GTR Series"},
                new Series() {Id=6,BrandId=3,Name="Z Series"},
            };
        }
        public IActionResult Index(int? id, string name)
        {

            if (id == null) return BadRequest("Brand Id is required");

            if (!_series.Exists(series => series.Id == id)) return NotFound($"{id} is not an existing Brand Id");
            IndexVM indexVM = new IndexVM();

            indexVM.SeriesList = _series.FindAll(series => series.BrandId == id);

            indexVM.Name = name;

            return View(indexVM);
        }
    }
}