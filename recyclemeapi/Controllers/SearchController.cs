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

    public ActionResult Get([FromQuery] String searchTerm, bool? plastics, bool? paper, bool? glass, bool? cardboard, bool? aluminum_cans, bool? electronics, bool? metal, bool? chemicals, bool? yard_waste)
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


      // get which ones materials we are searching for
      var materials = new List<string>();
      if (plastics.HasValue && plastics.Value)
      {
        materials.Add("Plastic");
      }
      if (paper.HasValue && paper.Value)
      {
        materials.Add("Paper");
      }
      if (glass.HasValue && glass.Value)
      {
        materials.Add("Glass");
      }
      if (cardboard.HasValue && cardboard.Value)
      {
        materials.Add("Cardboard");
      }
      if (aluminum_cans.HasValue && aluminum_cans.Value)
      {
        materials.Add("Aluminum Cans");
      }
      if (electronics.HasValue && electronics.Value)
      {
        materials.Add("Electronics");
      }
      if (metal.HasValue && metal.Value)
      {
        materials.Add("Metal");
      }
      if (chemicals.HasValue && chemicals.Value)
      {
        materials.Add("Chemicals");
      }
      if (yard_waste.HasValue && yard_waste.Value)
      {
        materials.Add("Yard Waste");
      }

      // Get the Ids of the materials we are searching for
      var materialsIds = db.Materials.Where(w => materials.Contains(w.MaterialType)).Select(s => s.Id);

      searchTerm = searchTerm.ToLower();

      // query the locationsMaterials table to select locations that have that 
      // This is where the filtering happens

      var locationsWithMaterials = db
         .LocationMaterials
         .Include(i => i.Location)
         .Include(i => i.Material)
         .Where(w =>
            materialsIds.Contains(w.MaterialsId)
            &&
            (
                w.Location.CenterName.ToLower().Contains(searchTerm) ||
                w.Location.City.ToLower().Contains(searchTerm) ||
                w.Location.Zip.Contains(searchTerm) ||
                w.Location.Address.ToLower().Contains(searchTerm)
            )
         )
         .Select(s => s.Id);

      // get the results needed formated in a way the UI wants it
      var locations = db
          .Locations
          .Include(i => i.LocationMaterials).ThenInclude(t => t.Material)
          .Where(w => locationsWithMaterials.Contains(w.Id));

      ////connect to database v
      //      var results = db.Locations.Include(i => i.LocationMaterials).ThenInclude(t => t.Material).Where(w =>
      //  w.City.ToLower().Contains(searchTerm.ToLower()) ||
      //  w.Zip.Contains(searchTerm) || w.CenterName.ToLower().Contains(searchTerm.ToLower()) ||
      //  w.Address.ToLower().Contains(searchTerm.ToLower())  /*||

      //  w.RecycleMeApi.Recycles.Contains(searchTerm.ToLower())
      //  how to make searching for recycleables/ combinations of recyclables possible
      //  including a dropdown filter next to search for recycleable type*/

      //);

      return Ok(locations);
    }
  }
}