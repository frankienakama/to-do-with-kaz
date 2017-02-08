using Nancy;
using System.Collections.Generic;
using PlacesBeen.Objects;

namespace PlacesBeen
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/view_all_places"] = _ => {
        Place newPlace = new Place(Request.Form["place-name"]);
        newPlace.Save();
        List<Place> allPlaces = Place.GetAll();
        return View["view_all_places.cshtml", allPlaces];
      };
      Get["/view_all_places"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["view_all_places.cshtml", allPlaces];
      };
      Post["/places_cleared"] = _ => {
        Place.ClearAll();
        return View["index.cshtml"];
      };
    }
  }
}
