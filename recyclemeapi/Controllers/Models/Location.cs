using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace recyclemeapi.Models
{
  public class Location
  {
    public int Id { get; set; }

    public string CenterName { get; set; }
    public string Address { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Zip { get; set; }

    public string PhoneNumber { get; set; }



    public int Rating { get; set; }


    public double Latitude { get; set; }
    public double Longitude { get; set; }



    public string weekdayHours { get; set; }

    public string weekendHours { get; set; }

    public List<LocationMaterials> LocationMaterials { get; set; } = new List<LocationMaterials>();

    //hours

    //"franchise"

  }
}

// TODO
// get it building,  v
// add at least 1 materail per location v
// migrate & update your db v 
// displaying materials on index page. 