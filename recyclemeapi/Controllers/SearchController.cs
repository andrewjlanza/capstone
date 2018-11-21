using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RecycleMeApi.Controllers

{
  [Route("api/[controller]")]
  [ApiController]
  public class SearchController : ControllerBase
  {


    [HttpGet]

    public ActionResult Get([FromQuery] String searchTerm, String plastics, String paper, String glass, String cardboard, String aluminum_cans, String electronics, String metal, String chemicals, String yard_waste)
    {
      var db = new RecycleMeApiContext();
      Console.WriteLine("search term is " + searchTerm);
      Console.WriteLine("plastics is " + plastics);
      Console.WriteLine("paper is " + paper);
      Console.WriteLine("glass is " + glass);
      Console.WriteLine("cardboard is " + cardboard);
      Console.WriteLine("aluminum_cans is " + aluminum_cans);
      Console.WriteLine("electronics is " + electronics);
      Console.WriteLine("metal is " + metal);
      Console.WriteLine("chemicals is " + chemicals);
      Console.WriteLine("yard_waste is " + yard_waste);




      //connect to database v
      var results = db.Locations.Include(i => i.LocationMaterials).ThenInclude(t => t.Material).Where(w =>
        w.City.ToLower().Contains(searchTerm.ToLower()) ||
        w.Zip.Contains(searchTerm) || w.CenterName.ToLower().Contains(searchTerm.ToLower()) ||
        w.Address.ToLower().Contains(searchTerm.ToLower())  /*||
        
        w.RecycleMeApi.Recycles.Contains(searchTerm.ToLower())
        how to make searching for recycleables/ combinations of recyclables possible
        including a dropdown filter next to search for recycleable type*/

      );

      return Ok(results);
    }
  }
}