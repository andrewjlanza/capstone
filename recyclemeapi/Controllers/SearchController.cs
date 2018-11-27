using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace RecycleMeApi.Controllers

{
  [Route("api/[controller]")]
  [ApiController]
  public class SearchController : ControllerBase
  {



    private List<string> GetMaterialListFilter(bool? plastics = null, bool? paper = null, bool? glass = null, bool? cardboard = null, bool? aluminum_cans = null, bool? electronics = null, bool? metal = null, bool? chemicals = null, bool? yard_waste = null)
    {
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
      return materials;
    }

    [HttpGet]

    public ActionResult Get([FromQuery] String searchTerm = null, bool? plastics = null, bool? paper = null, bool? glass = null, bool? cardboard = null, bool? aluminum_cans = null, bool? electronics = null, bool? metal = null, bool? chemicals = null, bool? yard_waste = null)
    {
      var db = new RecycleMeApiContext();
      Console.WriteLine("search term is " + searchTerm);

      var materials = GetMaterialListFilter(plastics, paper, glass, cardboard, aluminum_cans, electronics, metal, chemicals, yard_waste);
      // Get the Ids of the materials we are searching for
      var materialsIds = db.Materials.Where(w => materials.Contains(w.MaterialType)).Select(s => s.Id);

      searchTerm = searchTerm?.ToLower();

      // query the locationsMaterials table to select locations that have that 
      // This is where the filtering happens

      var filteredLocationsByName = db
              .LocationMaterials
              .Include(i => i.Location)
              .Include(i => i.Material)
              .AsQueryable();

      if (searchTerm != null)
      {
        filteredLocationsByName = filteredLocationsByName.Where(w => w.Location.CenterName.ToLower().Contains(searchTerm));
      }

      if (materialsIds.Any())
      {
        filteredLocationsByName = filteredLocationsByName
            .Where(w => materialsIds.Contains(w.MaterialsId));
      }

      var locationIds = filteredLocationsByName.Select(s => s.Id);

      var locations = db
                  .Locations
                  .Include(i => i.LocationMaterials).ThenInclude(t => t.Material)
                  .Where(w => locationIds.Contains(w.Id));

      return Ok(locations);
    }

    [HttpGet("nearby")]
    public ActionResult GetNearBy([FromQuery] double lat, [FromQuery] double lng, bool? plastics = null, bool? paper = null, bool? glass = null, bool? cardboard = null, bool? aluminum_cans = null, bool? electronics = null, bool? metal = null, bool? chemicals = null, bool? yard_waste = null)
    {

      var db = new RecycleMeApiContext();
      var materials = GetMaterialListFilter(plastics, paper, glass, cardboard, aluminum_cans, electronics, metal, chemicals, yard_waste);


      var rv = (from location in db.Locations
                let distance = Math.Sqrt(Math.Pow(location.Latitude - lat, 2) + Math.Pow(location.Longitude - lng, 2))        // where distance <= 10000

                select new { location = location, Distance = distance }).OrderByDescending(o => o.Distance).Select(s => s.location).Include(i => i.LocationMaterials).ThenInclude(t => t.Material).Take(5);//.Take(5).OrderBy(x => x.distance).ToList();



      return Ok(rv);
    }
  }
}