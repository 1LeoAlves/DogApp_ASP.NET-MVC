using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
	public class HelloWorldController : Controller
	{
		private static List<DogViewModel> dogs = new List<DogViewModel>();
		public IActionResult Index()
		{
			return View(dogs);
		}
		public string Hello()
		{
			return "Who's there?";
		}
		public IActionResult CreateDog(DogViewModel dogViewModel)
		{
			//return View("Index");
			dogs.Add(dogViewModel);
			return RedirectToAction(nameof(Index));
		}
		public IActionResult Create()
		{
			var dogVM = new DogViewModel();
			return View(dogVM);
		}

    }
}
