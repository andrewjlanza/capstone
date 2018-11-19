using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace recyclemeapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LocationsController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetAction()
    {
      var db = new RecycleMeApiContext();
      return Ok(db.Locations);
    }
  }
}