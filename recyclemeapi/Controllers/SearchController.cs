using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace recyclemeapi.Controllers

{
  [Route("api/[controller]")]
  [ApiController]
  public class SearchController : ControllerBase
  {


    [HttpGet]

    public ActionResult Get([FromQuery] String searchTerm)
    {
      var db = new RecycleMeApiContext();

      //connect to database v
      var results = db.Locations.Where(w =>
        w.City.ToLower().Contains(searchTerm.ToLower()) ||
        w.Zip.Contains(searchTerm) || w.CenterName.ToLower().Contains(searchTerm.ToLower()) ||
        w.Address.ToLower().Contains(searchTerm.ToLower()) /*||
        
        w.RecycleMeApi.Recycles.Contains(searchTerm.ToLower())
        how to make searching for recycleables/ combinations of recyclables possible
        including a dropdown filter next to search for recycleable type*/

      );

      return Ok(results);
    }
  }
}