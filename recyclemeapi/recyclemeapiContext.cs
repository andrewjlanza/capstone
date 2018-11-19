using System;
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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        optionsBuilder.UseNpgsql("server=localhost;database=recyclemeapi");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      modelBuilder.Entity<Location>().HasData(
        //about 'Recycles' vs. 'ItemsAccepted'
        new Location { Id = -1, CenterName = "Pinellas County Solid Waste", Address = "2855 109th Ave. N.", City = "St. Petersburg", State = "FL", Zip = "33716", PhoneNumber = "(727) 464-7500", Recycles = Recycles.Electronics, Rating = 3, Latitude = 27.875891, Longitude = -82.675450, ItemsAccepted = Recycles.Electronics },
        new Location { Id = -2, CenterName = "Pinellas County Recycling & Brush Site", Address = "1000 62nd Ave. N.E.", City = "St. Petersburg", State = "FL", Zip = "33702", PhoneNumber = "(727) 464-7500", Recycles = Recycles.Electronics, Rating = 3, Latitude = 27.875891, Longitude = -82.675450, ItemsAccepted = Recycles.Electronics, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -3, CenterName = "Pinellas County Recycling & Brush Site", Address = "7750 26th Ave. N.", City = "St. Petersburg", State = "FL", Zip = "33710", PhoneNumber = "(727) 464-7500", Recycles = Recycles.Electronics, Rating = 3, Latitude = 27.875891, Longitude = -82.675450, ItemsAccepted = Recycles.Electronics, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -4, CenterName = "Pinellas County Recycling & Brush Site", Address = "2453 20th Ave. N.", City = "St. Petersburg", State = "FL", Zip = "33713", PhoneNumber = "(727) 464-7500", Recycles = Recycles.Electronics, Rating = 3, Latitude = 27.875891, Longitude = -82.675450, ItemsAccepted = Recycles.Electronics, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -5, CenterName = "Pinellas County Recycling & Brush Site", Address = "2250 26th Ave. S.", City = "St. Petersburg", State = "FL", Zip = "33712", PhoneNumber = "(727) 464-7500", Recycles = Recycles.Electronics, Rating = 3, Latitude = 27.875891, Longitude = -82.675450, ItemsAccepted = Recycles.Electronics, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -6, CenterName = "Pinellas County Recycling & Brush Site", Address = "4015 Dr. MLK Jr. St. S.", City = "St. Petersburg", State = "FL", Zip = "33712", PhoneNumber = "(727) 464-7500", Recycles = Recycles.Electronics, Rating = 3, Latitude = 27.875891, Longitude = -82.675450, ItemsAccepted = Recycles.Electronics, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -8, CenterName = "Hillsborough County Solid Waste", Address = "456 imposter st", City = "Tampa", State = "FL", Zip = "33629", PhoneNumber = "(813) 555-5555", Recycles = Recycles.Metal, Rating = 5, Latitude = 27.909443, Longitude = -82.495022, ItemsAccepted = Recycles.Metal, weekdayHours = "", weekendHours = "" },
        new Location { Id = -9, CenterName = "Manatee County Solid Waste", Address = "789 false ave", City = "Sarasota", State = "FL", Zip = "34232", PhoneNumber = "(941) 222-2222", Recycles = Recycles.Plastic, Rating = 4, Latitude = 27.342242, Longitude = -82.494311, ItemsAccepted = Recycles.Plastic, weekdayHours = "", weekendHours = "" },
        new Location { Id = -10, CenterName = "Manatee County Solid Waste", Address = "789 false ave", City = "Sarasota", State = "FL", Zip = "34232", PhoneNumber = "(941) 222-2222", Recycles = Recycles.Plastic, Rating = 4, Latitude = 27.342242, Longitude = -82.494311, ItemsAccepted = Recycles.Plastic, weekdayHours = "", weekendHours = "" },
        new Location { Id = -12, CenterName = "Pinellas County Recycling & Brush Site", Address = "1000 62nd Ave. N.E.", City = "St. Petersburg", State = "FL", Zip = "33702", PhoneNumber = "(727) 464-7500", Recycles = Recycles.Electronics, Rating = 3, Latitude = 27.875891, Longitude = -82.675450, ItemsAccepted = Recycles.Electronics, weekdayHours = "", weekendHours = "" },
        new Location { Id = -11, CenterName = "Manatee County Solid Waste", Address = "789 false ave", City = "Sarasota", State = "FL", Zip = "34232", PhoneNumber = "(941) 222-2222", Recycles = Recycles.Plastic, Rating = 4, Latitude = 27.342242, Longitude = -82.494311, ItemsAccepted = Recycles.Plastic, weekdayHours = "", weekendHours = "" }

      );
      modelBuilder.Entity<Materials>().HasData(
        new Materials { Id = -1, MaterialType = "Paper" },
        new Materials { Id = -2, MaterialType = "Plastic" }
      );

      modelBuilder.Entity<LocationMaterials>().HasData(
        new LocationMaterials { Id = -1, LocationId = -1, MaterialsId = -1 },
        new LocationMaterials { Id = -1, LocationId = -1, MaterialsId = -2 }
      );/* making this display on the home page... requires some "includes" */

    }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Materials> Materials { get; set; }
    public DbSet<LocationMaterials> LocationMaterials { get; set; }


  }
}
