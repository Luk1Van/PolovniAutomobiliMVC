using Microsoft.AspNetCore.Mvc;
using PolovniAutomobiliMVC.Models;
using PolovniAutomobiliMVC.ViewModels;
using System.ComponentModel;

namespace PolovniAutomobiliMVC.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CarController(ICarRepository carRepository, ICategoryRepository categoryRepository)
        {
            _carRepository = carRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Details(int id)
        {
            var car = _carRepository.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
        public ViewResult List(int? categoryId)
        {
            CarListViewModel model = new CarListViewModel()
            {
                Cars = _carRepository.AllCars,
                CurrentCategory = "All cars"
            };
            if(categoryId.HasValue)
            {
                model.Cars = _carRepository.AllCars
                    .Where(c => c.CategoryId == categoryId);
                model.CurrentCategory = _categoryRepository.AllCategories
                                            .Where(c => c.Id == categoryId.Value)
                                            .Select(c => c.Name)
                                            .FirstOrDefault();
            }
            return View(model);
        }
    }
}
