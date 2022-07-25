using Microsoft.AspNetCore.Mvc;
using DoggoAppo.Models;

namespace DoggoAppo.Controllers
{
  public class HelloWorldController : Controller
  {

    private static List<DogViewModel> dogs = new List<DogViewModel>();

    public IActionResult Index()
    {
      /*   DogViewModel doggo = new DogViewModel()
        {
          Name = "Sippo",
          Age = 12
        }; */

      return View(dogs);
    }

    public IActionResult Create()
    {
      var dogVm = new DogViewModel();
      return View(dogVm);
    }

    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
      dogs.Add(dogViewModel);
      return RedirectToAction(nameof(Index));
    }

    public string Hello()
    {
      return "Who's there?";

    }

  }
}