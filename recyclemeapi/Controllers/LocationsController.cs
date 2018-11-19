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
      return Ok(db.Locations);
    }

    [HttpGet("{id}")]
    public ActionResult GetALocation([FromRoute] int id)
    {
      var db = new RecycleMeApiContext();
      return Ok(db.Locations
      .SingleOrDefault(s => s.Id == id));
    }
  }
}