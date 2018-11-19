using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace recyclemeapi.Migrations
{
    public partial class baseline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CenterName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Recycles = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    ItemsAccepted = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "CenterName", "City", "ItemsAccepted", "Latitude", "Longitude", "PhoneNumber", "Rating", "Recycles", "State", "Zip" },
                values: new object[] { -1, "2855 109th Ave. N.", "Pinellas County Solid Waste", "St. Petersburg", 3, 27.875891, -82.67545, "(727) 464-7500", 3, 3, "FL", "33716" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "CenterName", "City", "ItemsAccepted", "Latitude", "Longitude", "PhoneNumber", "Rating", "Recycles", "State", "Zip" },
                values: new object[] { -2, "456 imposter st", "Hillsborough County Solid Waste", "Tampa", 1, 27.909443, -82.495022, "(813) 555-5555", 5, 1, "FL", "33629" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "CenterName", "City", "ItemsAccepted", "Latitude", "Longitude", "PhoneNumber", "Rating", "Recycles", "State", "Zip" },
                values: new object[] { -3, "789 false ave", "Manatee County Solid Waste", "Sarasota", 0, 27.342242, -82.494311, "(941) 222-2222", 4, 0, "FL", "34232" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
