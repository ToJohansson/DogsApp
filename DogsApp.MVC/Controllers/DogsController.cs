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
    }
   
}
