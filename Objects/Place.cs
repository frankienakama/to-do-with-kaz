using System;
using System.Collections.Generic;
using PlacesBeen;

namespace PlacesBeen.Objects

{
  public class Place
  {
    private string _description;
    private static List<Place> _instances = new List<Place> {};

    public Place(string description)
    {
      _description = description;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
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
