using Microsoft.AspNetCore.Mvc;
using DoggoAppo.Models;

namespace DoggoAppo.Controllers
{


  public class HelloWorldController : Controller
  {
    public IActionResult Index()
    {
      DogViewModel doggo = new DogViewModel()
      {
        Name = "Sippo",
        Age = 12
      };

      return View(doggo);
    }

    public IActionResult Create()
    {
      return View();
    }

    public string Hello()
    {
      return "Who's there?";

    }

  }
}