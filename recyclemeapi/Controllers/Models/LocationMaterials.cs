using System.Collections.Generic;

namespace recyclemeapi.Models
{

  public class LocationMaterials
  {
    public int Id { get; set; }

    public int MaterialsId { get; set; }
    public Materials Material { get; set; }

    public int LocationId { get; set; }
    public Location Location { get; set; }

  }
}
