using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/cars")]
    public ActionResult Create(string carmodel, string year, string price)
    {
      Car myCar = new Car(carmodel, year, price);
      return RedirectToAction("Index");
    }
    [HttpGet("/cars/list")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

  }
}