using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class hours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hours",
                table: "Locations",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Address", "CenterName", "City", "Hours", "ItemsAccepted", "Latitude", "Longitude", "PhoneNumber", "Rating", "Recycles", "Zip" },
                values: new object[] { "7750 26th Ave. N.", "Pinellas County Recycling & Brush Site", "St. Petersburg", "Monday-Friday, 9 a.m. to 5:30 p.m.,Saturday and Sunday, 8 a.m. to 5:30 p.m.", 3, 27.875891, -82.67545, "(727) 464-7500", 3, 3, "33710" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Address", "CenterName", "City", "Hours", "ItemsAccepted", "Latitude", "Longitude", "PhoneNumber", "Rating", "Recycles", "Zip" },
                values: new object[] { "1000 62nd Ave. N.E.", "Pinellas County Recycling & Brush Site", "St. Petersburg", "Monday-Friday, 9 a.m. to 5:30 p.m.,Saturday and Sunday, 8 a.m. to 5:30 p.m.", 3, 27.875891, -82.67545, "(727) 464-7500", 3, 3, "33702" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "CenterName", "City", "Hours", "ItemsAccepted", "Latitude", "Longitude", "PhoneNumber", "Rating", "Recycles", "State", "Zip" },
                values: new object[,]
                {
                    { -4, "2453 20th Ave. N.", "Pinellas County Recycling & Brush Site", "St. Petersburg", "Monday-Friday, 9 a.m. to 5:30 p.m.,Saturday and Sunday, 8 a.m. to 5:30 p.m.", 3, 27.875891, -82.67545, "(727) 464-7500", 3, 3, "FL", "33713" },
                    { -5, "2250 26th Ave. S.", "Pinellas County Recycling & Brush Site", "St. Petersburg", "Monday-Friday, 9 a.m. to 5:30 p.m.,Saturday and Sunday, 8 a.m. to 5:30 p.m.", 3, 27.875891, -82.67545, "(727) 464-7500", 3, 3, "FL", "33712" },
                    { -6, "4015 Dr. MLK Jr. St. S.", "Pinellas County Recycling & Brush Site", "St. Petersburg", "Monday-Friday, 9 a.m. to 5:30 p.m.,Saturday and Sunday, 8 a.m. to 5:30 p.m.", 3, 27.875891, -82.67545, "(727) 464-7500", 3, 3, "FL", "33712" },
                    { -8, "456 imposter st", "Hillsborough County Solid Waste", "Tampa", "", 1, 27.909443, -82.495022, "(813) 555-5555", 5, 1, "FL", "33629" },
                    { -9, "789 false ave", "Manatee County Solid Waste", "Sarasota", "", 0, 27.342242, -82.494311, "(941) 222-2222", 4, 0, "FL", "34232" },
                    { -10, "789 false ave", "Manatee County Solid Waste", "Sarasota", "", 0, 27.342242, -82.494311, "(941) 222-2222", 4, 0, "FL", "34232" },
                    { -12, "1000 62nd Ave. N.E.", "Pinellas County Recycling & Brush Site", "St. Petersburg", "", 3, 27.875891, -82.67545, "(727) 464-7500", 3, 3, "FL", "33702" },
                    { -11, "789 false ave", "Manatee County Solid Waste", "Sarasota", "", 0, 27.342242, -82.494311, "(941) 222-2222", 4, 0, "FL", "34232" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DropColumn(
                name: "Hours",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Address", "CenterName", "City", "ItemsAccepted", "Latitude", "Longitude", "PhoneNumber", "Rating", "Recycles", "Zip" },
                values: new object[] { "789 false ave", "Manatee County Solid Waste", "Sarasota", 0, 27.342242, -82.494311, "(941) 222-2222", 4, 0, "34232" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Address", "CenterName", "City", "ItemsAccepted", "Latitude", "Longitude", "PhoneNumber", "Rating", "Recycles", "Zip" },
                values: new object[] { "456 imposter st", "Hillsborough County Solid Waste", "Tampa", 1, 27.909443, -82.495022, "(813) 555-5555", 5, 1, "33629" });
        }
    }
}
