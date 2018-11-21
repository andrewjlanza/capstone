/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RecycleMeApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MaterialsController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetCenter()
    {
      var db = new RecycleMeApiContext();
      return Ok(db.Locations.Include(i => i.LocationMaterials).ThenInclude(t => t.Material).Where());
    }
  }
} */
