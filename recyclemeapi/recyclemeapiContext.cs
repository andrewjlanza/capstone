using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using recyclemeapi.Models;

namespace recyclemeapi
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
        new Location { Id = -2, CenterName = "Hillsborough County Solid Waste", Address = "456 imposter st", City = "Tampa", State = "FL", Zip = "33629", PhoneNumber = "(813) 555-5555", Recycles = Recycles.Metal, Rating = 5, Latitude = 27.909443, Longitude = -82.495022, ItemsAccepted = Recycles.Metal },
        new Location { Id = -3, CenterName = "Manatee County Solid Waste", Address = "789 false ave", City = "Sarasota", State = "FL", Zip = "34232", PhoneNumber = "(941) 222-2222", Recycles = Recycles.Plastic, Rating = 4, Latitude = 27.342242, Longitude = -82.494311, ItemsAccepted = Recycles.Plastic }

      );


    }
    public DbSet<Location> Locations { get; set; }


  }
}
