using System.Collections.Generic;

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

    public Recycles Recycles { get; set; }
    //"PriceRange" is "Recycles"

    public int Rating { get; set; }


    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public Recycles ItemsAccepted { get; set; }

    //"franchise"

  }
}