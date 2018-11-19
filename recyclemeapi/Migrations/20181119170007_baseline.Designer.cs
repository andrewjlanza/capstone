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
    [Migration("20181119170007_baseline")]
    partial class baseline
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

                    b.Property<int>("ItemsAccepted");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("Rating");

                    b.Property<int>("Recycles");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new { Id = -1, Address = "2855 109th Ave. N.", CenterName = "Pinellas County Solid Waste", City = "St. Petersburg", ItemsAccepted = 3, Latitude = 27.875891, Longitude = -82.67545, PhoneNumber = "(727) 464-7500", Rating = 3, Recycles = 3, State = "FL", Zip = "33716" },
                        new { Id = -2, Address = "456 imposter st", CenterName = "Hillsborough County Solid Waste", City = "Tampa", ItemsAccepted = 1, Latitude = 27.909443, Longitude = -82.495022, PhoneNumber = "(813) 555-5555", Rating = 5, Recycles = 1, State = "FL", Zip = "33629" },
                        new { Id = -3, Address = "789 false ave", CenterName = "Manatee County Solid Waste", City = "Sarasota", ItemsAccepted = 0, Latitude = 27.342242, Longitude = -82.494311, PhoneNumber = "(941) 222-2222", Rating = 4, Recycles = 0, State = "FL", Zip = "34232" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}