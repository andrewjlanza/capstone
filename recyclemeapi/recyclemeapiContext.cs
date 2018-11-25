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
        new Location { Id = -1, CenterName = "Pinellas County Solid Waste", Address = "2855 109th Ave. N.", City = "St. Petersburg", State = "FL", Zip = "33716", PhoneNumber = "(727) 464-7500", Rating = 3, Latitude = 27.875891, Longitude = -82.675450, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -2, CenterName = "Pinellas County Recycling & Brush Site", Address = "1000 62nd Ave. N.E.", City = "St. Petersburg", State = "FL", Zip = "33702", PhoneNumber = "", Rating = 3, Latitude = 27.875891, Longitude = -82.675450, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -3, CenterName = "Pinellas County Recycling & Brush Site", Address = "7750 26th Ave. N.", City = "St. Petersburg", State = "FL", Zip = "33710", PhoneNumber = "", Rating = 3, Latitude = 27.875891, Longitude = -82.675450, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -4, CenterName = "Pinellas County Recycling & Brush Site", Address = "2453 20th Ave. N.", City = "St. Petersburg", State = "FL", Zip = "33713", PhoneNumber = "", Rating = 3, Latitude = 27.875891, Longitude = -82.675450, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -5, CenterName = "Pinellas County Recycling & Brush Site", Address = "2250 26th Ave. S.", City = "St. Petersburg", State = "FL", Zip = "33712", PhoneNumber = "", Rating = 3, Latitude = 27.875891, Longitude = -82.675450, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
        new Location { Id = -6, CenterName = "Pinellas County Recycling & Brush Site", Address = "4015 Dr. MLK Jr. St. S.", City = "St. Petersburg", State = "FL", Zip = "33712", PhoneNumber = "", Rating = 3, Latitude = 27.875891, Longitude = -82.675450, weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
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
          Latitude = 27.909443,
          Longitude = -82.495022,
          weekdayHours = "Monday - Tuesday 8:00 am - 8-00 pm  Wednesday 8:00 am - 5:00 pm. Thursday - Friday 8:00 am - 8:00 pm",
          weekendHours = ""
        },
          new Location { Id = -9, CenterName = "Crescent Lake Drop-Off", Address = " 1320 5th St. N.", City = "St. Petersburg", State = "FL", Zip = "33701", PhoneNumber = "", Rating = 4, Latitude = 27.342242, Longitude = -82.494311, weekdayHours = "", weekendHours = "" },
          new Location { Id = -10, CenterName = "Pinellas Bayway Drop-Off", Address = "3802 54th Ave. S.", City = "St. Petersburg", State = "FL", Zip = "33711", PhoneNumber = "", Rating = 4, Latitude = 27.342242, Longitude = -82.494311, weekdayHours = "", weekendHours = "" },
          new Location { Id = -11, CenterName = "Clearview United Methodist Drop-Off", Address = "4515 38th Ave N", City = "St. Petersburg", State = "FL", Zip = "34232", PhoneNumber = "", Rating = 4, Latitude = 27.342242, Longitude = -82.494311, weekdayHours = "", weekendHours = "" },
          new Location { Id = -12, CenterName = "Grace Lutheran Church Drop-Off", Address = "4364 15th St N", City = "St. Petersburg", State = "FL", Zip = "33703", PhoneNumber = "", Rating = 3, Latitude = 27.875891, Longitude = -82.675450, weekdayHours = "", weekendHours = "" },
          new Location { Id = -13, CenterName = "Municipal Marina Drop-Off", Address = "300 2nd Ave SE", City = "St. Petersburg", State = "FL", Zip = "33701", PhoneNumber = "", Rating = 4, Latitude = 27.342242, Longitude = -82.494311, weekdayHours = "", weekendHours = "" },
          new Location { Id = -14, CenterName = "municipal", Address = "300 2nd Ave SE", City = "St. Petersburg", State = "FL", Zip = "33701", PhoneNumber = "", Rating = 4, Latitude = 27.342242, Longitude = -82.494311, weekdayHours = "", weekendHours = "" }

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
        new LocationMaterials { Id = -15, LocationId = -14, MaterialsId = -6 }

      );/* making this display on the home page... requires some "includes" */

    }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Materials> Materials { get; set; }
    public DbSet<LocationMaterials> LocationMaterials { get; set; }


  }
}
