﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RecycleMeApi;

namespace recyclemeapi.Migrations
{
    [DbContext(typeof(RecycleMeApiContext))]
    [Migration("20181129185613_new oneon11")]
    partial class newoneon11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("Rating");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.Property<string>("weekdayHours");

                    b.Property<string>("weekendHours");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new { Id = -1, Address = "2855 109th Ave. N.", CenterName = "Pinellas County Solid Waste", City = "St. Petersburg", Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "(727) 464-7500", Rating = 3, State = "FL", Zip = "33716", weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
                        new { Id = -2, Address = "1000 62nd Ave. N.E.", CenterName = "Pinellas County Recycling & Brush Site", City = "St. Petersburg", Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "", Rating = 3, State = "FL", Zip = "33702", weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
                        new { Id = -3, Address = "7750 26th Ave. N.", CenterName = "Pinellas County Recycling & Brush Site", City = "St. Petersburg", Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "", Rating = 3, State = "FL", Zip = "33710", weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
                        new { Id = -4, Address = "2453 20th Ave. N.", CenterName = "Pinellas County Recycling & Brush Site", City = "St. Petersburg", Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "", Rating = 3, State = "FL", Zip = "33713", weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
                        new { Id = -5, Address = "2500 26th Ave. S.", CenterName = "Pinellas County Recycling & Brush Site", City = "St. Petersburg", Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "", Rating = 3, State = "FL", Zip = "33712", weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
                        new { Id = -6, Address = "4015 Dr. MLK Jr. St. S.", CenterName = "Pinellas County Recycling & Brush Site", City = "St. Petersburg", Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "", Rating = 3, State = "FL", Zip = "33712", weekdayHours = "Monday-Friday, 9 a.m. to 5:30 p.m.", weekendHours = "Saturday and Sunday, 8 a.m. to 5:30 p.m." },
                        new { Id = -8, Address = " 1111 18th Ave. S.", CenterName = "Enoch Davis Recreation Center", City = "St. Petersburg", Latitude = 27.909443, Longitude = -82.495022, PhoneNumber = "(727) 893-7134", Rating = 5, State = "FL", Zip = "33705", weekdayHours = "Monday - Tuesday 8:00 am - 8-00 pm  Wednesday 8:00 am - 5:00 pm. Thursday - Friday 8:00 am - 8:00 pm", weekendHours = "" },
                        new { Id = -9, Address = " 1320 5th St. N.", CenterName = "Crescent Lake Drop-Off", City = "St. Petersburg", Latitude = 27.342242, Longitude = -82.494311, PhoneNumber = "", Rating = 4, State = "FL", Zip = "33701", weekdayHours = "", weekendHours = "" },
                        new { Id = -10, Address = "3802 54th Ave. S.", CenterName = "Pinellas Bayway Drop-Off", City = "St. Petersburg", Latitude = 27.342242, Longitude = -82.494311, PhoneNumber = "", Rating = 4, State = "FL", Zip = "33711", weekdayHours = "", weekendHours = "" },
                        new { Id = -11, Address = "4515 38th Ave N", CenterName = "Clearview United Methodist Drop-Off", City = "St. Petersburg", Latitude = 27.342242, Longitude = -82.494311, PhoneNumber = "", Rating = 4, State = "FL", Zip = "34232", weekdayHours = "", weekendHours = "" },
                        new { Id = -12, Address = "4364 15th St N", CenterName = "Grace Lutheran Church Drop-Off", City = "St. Petersburg", Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "", Rating = 3, State = "FL", Zip = "33703", weekdayHours = "", weekendHours = "" },
                        new { Id = -13, Address = "300 2nd Ave SE", CenterName = "Municipal Marina Drop-Off", City = "St. Petersburg", Latitude = 27.342242, Longitude = -82.494311, PhoneNumber = "", Rating = 4, State = "FL", Zip = "33701", weekdayHours = "", weekendHours = "" },
                        new { Id = -15, Address = "1023 Gulf Rd", CenterName = "Tarpon Springs Fire Rescue Station 70", City = "Tarpon Springs", Latitude = 28.1449662, Longitude = -82.7722478, PhoneNumber = "", Rating = 4, State = "FL", Zip = "34689", weekdayHours = "", weekendHours = "" },
                        new { Id = -16, Address = "898 S Levis Ave.", CenterName = "Tarpon Springs Yard Waste Facility", City = "Tarpon Springs", Latitude = 28.1381046, Longitude = -82.7503984, PhoneNumber = "(727) 943-0067", Rating = 4, State = "FL", Zip = "34689", weekdayHours = "Monday - Friday, 7am - 4:30pm", weekendHours = "Saturday, 7am - 12pm" }
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

                    b.HasData(
                        new { Id = -1, LocationId = -1, MaterialsId = -1 },
                        new { Id = -2, LocationId = -2, MaterialsId = -2 },
                        new { Id = -3, LocationId = -3, MaterialsId = -3 },
                        new { Id = -4, LocationId = -4, MaterialsId = -4 },
                        new { Id = -5, LocationId = -5, MaterialsId = -5 },
                        new { Id = -6, LocationId = -6, MaterialsId = -6 },
                        new { Id = -8, LocationId = -8, MaterialsId = -8 },
                        new { Id = -9, LocationId = -9, MaterialsId = -9 },
                        new { Id = -10, LocationId = -10, MaterialsId = -1 },
                        new { Id = -11, LocationId = -11, MaterialsId = -2 },
                        new { Id = -12, LocationId = -12, MaterialsId = -3 },
                        new { Id = -13, LocationId = -13, MaterialsId = -4 },
                        new { Id = -14, LocationId = -14, MaterialsId = -5 },
                        new { Id = -15, LocationId = -14, MaterialsId = -6 },
                        new { Id = -16, LocationId = -15, MaterialsId = -6 },
                        new { Id = -17, LocationId = -15, MaterialsId = -8 }
                    );
                });

            modelBuilder.Entity("recyclemeapi.Models.Materials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaterialType");

                    b.HasKey("Id");

                    b.ToTable("Materials");

                    b.HasData(
                        new { Id = -1, MaterialType = "Plastic" },
                        new { Id = -2, MaterialType = "Metal" },
                        new { Id = -3, MaterialType = "Paper" },
                        new { Id = -4, MaterialType = "Electronics" },
                        new { Id = -5, MaterialType = "Glass" },
                        new { Id = -6, MaterialType = "Chemicals" },
                        new { Id = -7, MaterialType = "Yard Waste" },
                        new { Id = -8, MaterialType = "Cardboard" },
                        new { Id = -9, MaterialType = "Aluminum Cans" }
                    );
                });

            modelBuilder.Entity("recyclemeapi.Models.LocationMaterials", b =>
                {
                    b.HasOne("recyclemeapi.Models.Location", "Location")
                        .WithMany("LocationMaterials")
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
