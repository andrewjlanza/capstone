﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RecycleMeApi;

namespace recyclemeapi.Migrations
{
    [DbContext(typeof(RecycleMeApiContext))]
    partial class RecycleMeApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("recyclemeapi.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CenterName");

                    b.Property<string>("City");

                    b.Property<int>("ItemsAccepted");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("Rating");

                    b.Property<int>("Recycles");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.Property<string>("weekdayHours");

                    b.Property<string>("weekendHours");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new { Id = -1, Address = "2855 109th Ave. N.", CenterName = "Pinellas County Solid Waste", City = "St. Petersburg", ItemsAccepted = 3, Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "(727) 464-7500", Rating = 3, Recycles = 3, State = "FL", Zip = "33716" },
                        new { Id = -2, Address = "1000 62nd Ave. N.E.", CenterName = "Pinellas County Recycling & Brush Site", City = "St. Petersburg", ItemsAccepted = 3, Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "(727) 464-7500", Rating = 3, Recycles = 3, State = "FL", Zip = "33702", weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
                        new { Id = -3, Address = "7750 26th Ave. N.", CenterName = "Pinellas County Recycling & Brush Site", City = "St. Petersburg", ItemsAccepted = 3, Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "(727) 464-7500", Rating = 3, Recycles = 3, State = "FL", Zip = "33710", weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
                        new { Id = -4, Address = "2453 20th Ave. N.", CenterName = "Pinellas County Recycling & Brush Site", City = "St. Petersburg", ItemsAccepted = 3, Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "(727) 464-7500", Rating = 3, Recycles = 3, State = "FL", Zip = "33713", weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
                        new { Id = -5, Address = "2250 26th Ave. S.", CenterName = "Pinellas County Recycling & Brush Site", City = "St. Petersburg", ItemsAccepted = 3, Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "(727) 464-7500", Rating = 3, Recycles = 3, State = "FL", Zip = "33712", weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
                        new { Id = -6, Address = "4015 Dr. MLK Jr. St. S.", CenterName = "Pinellas County Recycling & Brush Site", City = "St. Petersburg", ItemsAccepted = 3, Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "(727) 464-7500", Rating = 3, Recycles = 3, State = "FL", Zip = "33712", weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
                        new { Id = -8, Address = "456 imposter st", CenterName = "Hillsborough County Solid Waste", City = "Tampa", ItemsAccepted = 1, Latitude = 27.909443, Longitude = -82.495022, PhoneNumber = "(813) 555-5555", Rating = 5, Recycles = 1, State = "FL", Zip = "33629", weekdayHours = "", weekendHours = "" },
                        new { Id = -9, Address = "789 false ave", CenterName = "Manatee County Solid Waste", City = "Sarasota", ItemsAccepted = 0, Latitude = 27.342242, Longitude = -82.494311, PhoneNumber = "(941) 222-2222", Rating = 4, Recycles = 0, State = "FL", Zip = "34232", weekdayHours = "", weekendHours = "" },
                        new { Id = -10, Address = "789 false ave", CenterName = "Manatee County Solid Waste", City = "Sarasota", ItemsAccepted = 0, Latitude = 27.342242, Longitude = -82.494311, PhoneNumber = "(941) 222-2222", Rating = 4, Recycles = 0, State = "FL", Zip = "34232", weekdayHours = "", weekendHours = "" },
                        new { Id = -12, Address = "1000 62nd Ave. N.E.", CenterName = "Pinellas County Recycling & Brush Site", City = "St. Petersburg", ItemsAccepted = 3, Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "(727) 464-7500", Rating = 3, Recycles = 3, State = "FL", Zip = "33702", weekdayHours = "", weekendHours = "" },
                        new { Id = -11, Address = "789 false ave", CenterName = "Manatee County Solid Waste", City = "Sarasota", ItemsAccepted = 0, Latitude = 27.342242, Longitude = -82.494311, PhoneNumber = "(941) 222-2222", Rating = 4, Recycles = 0, State = "FL", Zip = "34232", weekdayHours = "", weekendHours = "" }
                    );
                });

            modelBuilder.Entity("recyclemeapi.Models.LocationMaterials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LocationId");

                    b.Property<int>("MaterialsId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("MaterialsId");

                    b.ToTable("LocationMaterials");
                });

            modelBuilder.Entity("recyclemeapi.Models.Materials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaterialType");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("recyclemeapi.Models.LocationMaterials", b =>
                {
                    b.HasOne("recyclemeapi.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("recyclemeapi.Models.Materials", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
