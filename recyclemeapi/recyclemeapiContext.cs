using System;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using recyclemeapi.Models;

namespace RecycleMeApi
{
  public partial class RecycleMeApiContext : DbContext
  {
    public RecycleMeApiContext()
    {
    }

    public RecycleMeApiContext(DbContextOptions<RecycleMeApiContext> options)
        : base(options)
    {
    }

    private string ConvertPostConnectionToConnectionString(string connection)
    {
      var _connection = connection.Replace("postgres://", String.Empty);
      var output = Regex.Split(_connection, ":|@|/");
      return $"server={output[2]};database={output[4]};User Id={output[0]}; password={output[1]}; port={output[3]}";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        var envConn = Environment.GetEnvironmentVariable("DATABASE_URL");
        var conn = "server=localhost;database=RecycleMeApi";
        if (envConn != null)
        {
          conn = ConvertPostConnectionToConnectionString(envConn);
        }
        optionsBuilder.UseNpgsql(conn);
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      modelBuilder.Entity<Location>().HasData(
        //about 'Recycles' vs. 'ItemsAccepted'
        new Location { Id = -1, CenterName = "Pinellas County Solid Waste", Address = "2855 109th Ave. N.", City = "St. Petersburg", State = "FL", Zip = "33716", PhoneNumber = "(727) 464-7500", Rating = 3, Latitude = 27.87395, Longitude = -82.67436, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -2, CenterName = "Pinellas County Recycling & Brush Site", Address = "1000 62nd Ave. N.E.", City = "St. Petersburg", State = "FL", Zip = "33702", PhoneNumber = "", Rating = 3, Latitude = 27.828215, Longitude = -82.62371, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -3, CenterName = "Pinellas County Recycling & Brush Site", Address = "7750 26th Ave. N.", City = "St. Petersburg", State = "FL", Zip = "33710", PhoneNumber = "", Rating = 3, Latitude = 27.795445, Longitude = -82.704636, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -4, CenterName = "Pinellas County Recycling & Brush Site", Address = "2453 20th Ave. N.", City = "St. Petersburg", State = "FL", Zip = "33713", PhoneNumber = "", Rating = 3, Latitude = 27.790123, Longitude = -82.666833, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -5, CenterName = "Pinellas County Recycling & Brush Site", Address = "2500 26th Ave. S.", City = "St. Petersburg", State = "FL", Zip = "33712", PhoneNumber = "", Rating = 3, Latitude = 27.74549, Longitude = -82.66848, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -6, CenterName = "Pinellas County Recycling & Brush Site", Address = "4015 Dr. MLK Jr. St. S.", City = "St. Petersburg", State = "FL", Zip = "33712", PhoneNumber = "", Rating = 3, Latitude = 27.730649, Longitude = -82.645629, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location
        {
          Id = -8,
          CenterName = "Enoch Davis Recreation Center",
          Address = " 1111 18th Ave. S.",
          City = "St. Petersburg",
          State = "FL",
          Zip = "33705",
          PhoneNumber = "(727) 893-7134",
          Rating = 5,
          Latitude = 27.752473,
          Longitude = -82.650372,
          weekdayHours = "Monday - Tuesday 8:00 am - 8-00 pm  Wednesday 8:00 am - 5:00 pm. Thursday - Friday 8:00 am - 8:00 pm",
          weekendHours = ""
        },
          new Location { Id = -9, CenterName = "Crescent Lake Drop-Off", Address = " 1320 5th St. N.", City = "St. Petersburg", State = "FL", Zip = "33701", PhoneNumber = "", Rating = 4, Latitude = 27.78592, Longitude = -82.640488, weekdayHours = "", weekendHours = "" },
          new Location { Id = -10, CenterName = "Pinellas Bayway Drop-Off", Address = "3802 54th Ave. S.", City = "St. Petersburg", State = "FL", Zip = "33711", PhoneNumber = "", Rating = 4, Latitude = 27.71836, Longitude = -82.68205, weekdayHours = "", weekendHours = "" },
          new Location { Id = -11, CenterName = "Clearview United Methodist Drop-Off", Address = "4515 38th Ave N", City = "St. Petersburg", State = "FL", Zip = "33713", PhoneNumber = "", Rating = 4, Latitude = 27.806876, Longitude = -82.694447, weekdayHours = "", weekendHours = "" },
          new Location { Id = -12, CenterName = "Grace Lutheran Drop-Off", Address = "4300 Haines Rd.", City = "St. Petersburg", State = "FL", Zip = "33714", PhoneNumber = "", Rating = 3, Latitude = 27.810599, Longitude = -82.655398, weekdayHours = "", weekendHours = "" },
          new Location { Id = -13, CenterName = "Municipal Marina Drop-Off", Address = "300 2nd Ave SE", City = "St. Petersburg", State = "FL", Zip = "33701", PhoneNumber = "", Rating = 4, Latitude = 27.769472, Longitude = -82.630048, weekdayHours = "", weekendHours = "" },

          new Location { Id = -15, CenterName = "Tarpon Springs Fire Rescue Station 70", Address = "1023 Gulf Rd", City = "Tarpon Springs", State = "FL", Zip = "34689", PhoneNumber = "", Rating = 4, Latitude = 28.1449662, Longitude = -82.7722478, weekdayHours = "", weekendHours = "" },
          new Location { Id = -16, CenterName = "Tarpon Springs Yard Waste Facility", Address = "898 S Levis Ave.", City = "Tarpon Springs", State = "FL", Zip = "34689", PhoneNumber = "(727) 943-0067", Rating = 4, Latitude = 28.1381046, Longitude = -82.7503984, weekdayHours = "Monday - Friday, 7am - 4:30pm", weekendHours = "Saturday, 7am - 12pm" },
          new Location { Id = -17, CenterName = "Brooker Creek Education Center", Address = "3940 Keystone Rd.", City = "Tarpon Springs", State = "FL", Zip = "34688", PhoneNumber = "", Rating = 4, Latitude = 27.9047092, Longitude = -82.6720455, weekdayHours = "", weekendHours = "" },
          new Location { Id = -18, CenterName = "A.L. Anderson Park, Between Klosterman Rd. and Tarpon Ave ", Address = "3940 Keystone Rd.", City = "Tarpon Springs", State = "FL", Zip = "34689", PhoneNumber = "", Rating = 4, Latitude = 28.13414, Longitude = -82.738827, weekdayHours = "", weekendHours = "" },
          new Location { Id = -19, CenterName = "William E. Dunn Water Reclamation Facility, Off Alt U.S. 19 N", Address = "4111 Dunn Dr. ", City = "Palm Harbor", State = "FL", Zip = "34683", PhoneNumber = "", Rating = 4, Latitude = 28.10988, Longitude = -82.765189, weekdayHours = "", weekendHours = "" },
          new Location { Id = -20, CenterName = "John Chesnut Sr. Park ", Address = "2200 East Lake Rd.", City = "Palm Harbor", State = "FL", Zip = "34685", PhoneNumber = "", Rating = 4, Latitude = 28.087942, Longitude = -82.702042, weekdayHours = "", weekendHours = "" },
          new Location { Id = -21, CenterName = "Curlew Retention Pond, Between Belcher Rd. and CR 1 ", Address = "1825 Curlew Rd. ", City = "Palm Harbor", State = "FL", Zip = "34683", PhoneNumber = "", Rating = 4, Latitude = 28.049431, Longitude = -82.752827, weekdayHours = "", weekendHours = "" },
          new Location { Id = -22, CenterName = "Highlander Park Recycling Site, Across from Highlander Pool ", Address = "1940 Ed Eckert Dr. ", City = "Dunedin", State = "FL", Zip = "34698", PhoneNumber = "", Rating = 4, Latitude = 28.036594, Longitude = -82.777803, weekdayHours = "", weekendHours = "" },
          new Location { Id = -23, CenterName = "Lake Haven Recycling Center", Address = "817 Lake Haven Rd. ", City = "Dunedin", State = "FL", Zip = "34698", PhoneNumber = "", Rating = 4, Latitude = 28.017087, Longitude = -82.770546, weekdayHours = "", weekendHours = "" },
          new Location { Id = -24, CenterName = "Safety Harbor Fire Station 53", Address = "3095 McMullen Booth Rd", City = "Clearwater", State = "FL", Zip = "33761", PhoneNumber = "", Rating = 4, Latitude = 28.033941, Longitude = -82.708135, weekdayHours = "", weekendHours = "" },
          new Location { Id = -25, CenterName = "Safety Harbor Public Works", Address = "1200 Railroad Ave", City = "Safety Harbor", State = "FL", Zip = "34695", PhoneNumber = "", Rating = 4, Latitude = 27.999967, Longitude = -82.69599, weekdayHours = "", weekendHours = "" },
          new Location { Id = -26, CenterName = "North County Service Center,  West side, south of Curlew Rd.", Address = "29582 U.S. 19 N", City = "Clearwater", State = "FL", Zip = "33761", PhoneNumber = "", Rating = 4, Latitude = 28.034406, Longitude = -82.732479, weekdayHours = "", weekendHours = "" },
          new Location { Id = -27, CenterName = "Clearwater Solid Waste Facility", Address = "1701 N Hercules Ave.", City = "Clearwater", State = "FL", Zip = "33765", PhoneNumber = "", Rating = 4, Latitude = 27.982803, Longitude = -82.752747, weekdayHours = "", weekendHours = "" },
          new Location { Id = -28, CenterName = "Walmart, SE corner of parking lot", Address = "23106 U.S. 19 N", City = "Clearwater", State = "FL", Zip = "33765", PhoneNumber = "", Rating = 4, Latitude = 27.983581, Longitude = -82.731369, weekdayHours = "", weekendHours = "" },
          new Location { Id = -29, CenterName = "Sand Key Park", Address = "1060 Gulf Blvd", City = "Clearwater", State = "FL", Zip = "33767", PhoneNumber = "", Rating = 4, Latitude = 27.96442, Longitude = -82.82241, weekdayHours = "", weekendHours = "" },
          new Location { Id = -30, CenterName = "John J. Osborne Public Works Building", Address = "1075 Ponce de Leon Blvd.", City = "Belleair", State = "FL", Zip = "33756", PhoneNumber = "", Rating = 4, Latitude = 27.933655, Longitude = -82.800926, weekdayHours = "", weekendHours = "" },
          new Location { Id = -31, CenterName = "Fossil Park", Address = "6635 Dr. MLK Jr. St. N", City = "St. Petersburg", State = "FL", Zip = "33702", PhoneNumber = "", Rating = 4, Latitude = 27.82923, Longitude = -82.64527, weekdayHours = "", weekendHours = "" },
          new Location { Id = -32, CenterName = "Northwest Park", Address = "2331 60th Ave. N", City = "St. Petersburg", State = "FL", Zip = "33710", PhoneNumber = "", Rating = 4, Latitude = 27.79295, Longitude = -82.715668, weekdayHours = "", weekendHours = "" },
          new Location { Id = -33, CenterName = "St. Petersburg Public Library", Address = "3745 9th Ave. N", City = "St. Petersburg", State = "FL", Zip = "33713", PhoneNumber = "", Rating = 4, Latitude = 27.78169, Longitude = -82.684268, weekdayHours = "", weekendHours = "" },
          new Location { Id = -34, CenterName = "Bay Vista Park", Address = "7000 4th St. S", City = "St. Petersburg", State = "FL", Zip = "33705", PhoneNumber = "", Rating = 4, Latitude = 27.704539, Longitude = -82.641212, weekdayHours = "", weekendHours = "" }

      );
      modelBuilder.Entity<Materials>().HasData(
        new Materials { Id = -1, MaterialType = "Plastic" },
        new Materials { Id = -2, MaterialType = "Metal" },
        new Materials { Id = -3, MaterialType = "Paper" },
        new Materials { Id = -4, MaterialType = "Electronics" },
        new Materials { Id = -5, MaterialType = "Glass" },
        new Materials { Id = -6, MaterialType = "Chemicals" },
        new Materials { Id = -7, MaterialType = "Yard Waste" },
        new Materials { Id = -8, MaterialType = "Cardboard" },
        new Materials { Id = -9, MaterialType = "Aluminum Cans" }



      );

      modelBuilder.Entity<LocationMaterials>().HasData(
        new LocationMaterials { Id = -1, LocationId = -1, MaterialsId = -1 },
        new LocationMaterials { Id = -29, LocationId = -1, MaterialsId = -2 },
        new LocationMaterials { Id = -30, LocationId = -1, MaterialsId = -3 },
        new LocationMaterials { Id = -31, LocationId = -1, MaterialsId = -4 },
        new LocationMaterials { Id = -32, LocationId = -1, MaterialsId = -5 },
        new LocationMaterials { Id = -33, LocationId = -1, MaterialsId = -6 },
        new LocationMaterials { Id = -34, LocationId = -1, MaterialsId = -7 },
        new LocationMaterials { Id = -35, LocationId = -1, MaterialsId = -8 },
        new LocationMaterials { Id = -36, LocationId = -1, MaterialsId = -9 },
        new LocationMaterials { Id = -2, LocationId = -2, MaterialsId = -2 },
        new LocationMaterials { Id = -3, LocationId = -3, MaterialsId = -3, },
        new LocationMaterials { Id = -4, LocationId = -4, MaterialsId = -4 },
        new LocationMaterials { Id = -5, LocationId = -5, MaterialsId = -5 },
        new LocationMaterials { Id = -6, LocationId = -6, MaterialsId = -6 },
        // new LocationMaterials { Id = -7, LocationId = -7, MaterialsId = -7 },
        new LocationMaterials { Id = -8, LocationId = -8, MaterialsId = -8 },
        new LocationMaterials { Id = -9, LocationId = -9, MaterialsId = -9 },
        new LocationMaterials { Id = -10, LocationId = -10, MaterialsId = -1 },
        new LocationMaterials { Id = -11, LocationId = -11, MaterialsId = -2 },
        new LocationMaterials { Id = -12, LocationId = -12, MaterialsId = -3 },
        new LocationMaterials { Id = -13, LocationId = -13, MaterialsId = -4 },
        new LocationMaterials { Id = -14, LocationId = -14, MaterialsId = -5 },
        new LocationMaterials { Id = -15, LocationId = -14, MaterialsId = -6 },
        new LocationMaterials { Id = -16, LocationId = -15, MaterialsId = -1 },
        new LocationMaterials { Id = -17, LocationId = -15, MaterialsId = -8 },
        new LocationMaterials { Id = -18, LocationId = -16, MaterialsId = -1 },
        new LocationMaterials { Id = -19, LocationId = -16, MaterialsId = -3 },
        new LocationMaterials { Id = -20, LocationId = -16, MaterialsId = -5 },
        new LocationMaterials { Id = -21, LocationId = -16, MaterialsId = -8 },
        new LocationMaterials { Id = -22, LocationId = -16, MaterialsId = -9 },
        new LocationMaterials { Id = -23, LocationId = -16, MaterialsId = -7 },
        new LocationMaterials { Id = -24, LocationId = -15, MaterialsId = -3 },
        new LocationMaterials { Id = -25, LocationId = -15, MaterialsId = -5 },
        new LocationMaterials { Id = -26, LocationId = -15, MaterialsId = -9 },
        new LocationMaterials { Id = -27, LocationId = -17, MaterialsId = -1 },
        new LocationMaterials { Id = -28, LocationId = -17, MaterialsId = -3 },
        new LocationMaterials { Id = -42, LocationId = -17, MaterialsId = -5 },
        new LocationMaterials { Id = -43, LocationId = -17, MaterialsId = -7 },
        new LocationMaterials { Id = -37, LocationId = -18, MaterialsId = -1 },
        new LocationMaterials { Id = -38, LocationId = -18, MaterialsId = -3 },
        new LocationMaterials { Id = -39, LocationId = -18, MaterialsId = -5 },
        new LocationMaterials { Id = -40, LocationId = -18, MaterialsId = -8 },
        new LocationMaterials { Id = -41, LocationId = -18, MaterialsId = -9 },
        new LocationMaterials { Id = -44, LocationId = -19, MaterialsId = -1 },
        new LocationMaterials { Id = -45, LocationId = -19, MaterialsId = -3 },
        new LocationMaterials { Id = -46, LocationId = -19, MaterialsId = -5 },
        new LocationMaterials { Id = -47, LocationId = -19, MaterialsId = -8 },
        new LocationMaterials { Id = -48, LocationId = -19, MaterialsId = -9 }


      );/* making this display on the home page... requires some "includes" */

    }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Materials> Materials { get; set; }
    public DbSet<LocationMaterials> LocationMaterials { get; set; }


  }
}
