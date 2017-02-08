using System;
using System.Collections.Generic;
using PlacesBeen;

namespace PlacesBeen.Objects

{
  public class Place
  {
    private string _description;
    private int _year;
    private string _favThing;
    private static List<Place> _instances = new List<Place> {};

    public Place(string description, int year, string favThing)
    {
      _description = description;
      _year = year;
      _favThing = favThing;
    }
// description
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
  // year
    public int GetYear()
    {
      return _year;
    }
    public void SetYear(int newYear)
    {
      _year = newYear;
    }
  // favorite thing
    public string GetFavThing()
    {
      return _favThing;
    }
    public void SetFavThing(string newFavThing)
    {
      _favThing = newFavThing;
    }
  // list
    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public void Save()
    {
      _instances.Add(this);
    }
  }
}
