using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class InitialDataSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Locations",
                newName: "CenterName");

            migrationBuilder.AddColumn<int>(
                name: "ItemsAccepted",
                table: "Locations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Locations",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Locations",
                nullable: false,
                defaultValue: 0.0);

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
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "ItemsAccepted",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "CenterName",
                table: "Locations",
                newName: "ImageUrl");
        }
    }
}
