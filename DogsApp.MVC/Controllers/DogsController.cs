using DogsApp.MVC.Services;
using Microsoft.AspNetCore.Mvc;
using DogsApp.MVC.Models;

namespace DogsApp.MVC.Controllers
{
    public class DogsController : Controller
    {
        static DogService dogService = new DogService();

        [Route("/")]
        public IActionResult Index()
        {
            return View(dogService.GetAllDogs());
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Dog dog)
        {
          dogService.AddDog(dog);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet("edit/{id:int}")]
        public IActionResult Edit(int id)
        {
            var dog = dogService.GetDogById(id);
            return View(dog);
        }
        [HttpPost("edit/{id:int}")]
        public IActionResult Edit(int id, Dog dog)
        {
            var existingDog = dogService.GetDogById(id);
            existingDog.Name = dog.Name;
            existingDog.Age = dog.Age;
            return RedirectToAction(nameof(Index));
        }
        [HttpPost("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var dog = dogService.GetDogById(id);
            dogService.RemoveDog(dog);
            return RedirectToAction(nameof(Index));
        }
    }
   
}
