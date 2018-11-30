using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class newoneone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.InsertData(
                table: "LocationMaterials",
                columns: new[] { "Id", "LocationId", "MaterialsId" },
                values: new object[,]
                {
                    { -16, -15, -6 },
                    { -17, -15, -8 }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Address", "CenterName", "PhoneNumber", "weekdayHours", "weekendHours" },
                values: new object[] { "898 S Levis Ave.", "Tarpon Springs Yard Waste Facility", "(727) 943-0067", "7am - 4:30pm", "Saturday, 7am - 12pm" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 29.333, 82.333 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Address", "CenterName", "PhoneNumber", "weekdayHours", "weekendHours" },
                values: new object[] { "1023 Gulf Rd", "Tarpon Springs Drop-Off", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.342242, -82.494311 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "CenterName", "City", "Latitude", "Longitude", "PhoneNumber", "Rating", "State", "Zip", "weekdayHours", "weekendHours" },
                values: new object[] { -14, "300 2nd Ave SE", "municipal", "St. Petersburg", 27.342242, -82.494311, "", 4, "FL", "33701", "", "" });
        }
    }
}
