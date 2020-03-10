using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Carmodel { get; set; }
    public string Year { get; set; }
    public string Price { get; set; }
    private static List<Car> _instances = new List<Car> {};

    public Car (string carmodel, string year, string price)
    {
      Carmodel = carmodel;
      Year = year;
      Price = price;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

  }
}