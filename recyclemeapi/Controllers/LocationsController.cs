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
  public class LocationsController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetAction()
    {
      var db = new RecycleMeApiContext();
      return Ok(db.Locations.Include(i => i.LocationMaterials).ThenInclude(t => t.Material));
    }

    [HttpGet("{id}")]
    public ActionResult GetALocation([FromRoute] int id)
    {
      var db = new RecycleMeApiContext();
      return Ok(db.Locations
      /* .Include(i => i.Materials)
      .Include(i => i.LocationMaterials)
 */      .SingleOrDefault(s => s.Id == id));
    }
  }
}/* [HttpGet("{id}/reviews/{userId}")]
        public ActionResult GetUserReview([FromRoute] int id, [FromRoute] string userId)
        {
            // query the review table to get the firstordefault (f => f.locationId && f.userId )
            var db = new CoffeeShopFinderContext();
            var review = db.Reviews.FirstOrDefault(f => f.LocationId == id && f.UserId == userId);
            // if (found)
            if (review != null)
            {
                return Ok(new { wasFound = true, review });
            }
            else
            {
                return Ok(new { wasFound = false });
            }
            // return that 
            // else return a not found message

        } */

