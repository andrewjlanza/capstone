using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class newone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -5,
                column: "Address",
                value: "2500 26th Ave. S.");

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "CenterName", "City", "Latitude", "Longitude", "PhoneNumber", "Rating", "State", "Zip", "weekdayHours", "weekendHours" },
                values: new object[] { -15, "1023 Gulf Rd", "Tarpon Springs Fire Rescue Station 70", "Tarpon Springs", 27.342242, -82.494311, "", 4, "FL", "34689", "", "" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "CenterName", "City", "Latitude", "Longitude", "PhoneNumber", "Rating", "State", "Zip", "weekdayHours", "weekendHours" },
                values: new object[] { -16, "1023 Gulf Rd", "Tarpon Springs Drop-Off", "Tarpon Springs", 27.342242, -82.494311, "", 4, "FL", "34689", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -5,
                column: "Address",
                value: "2250 26th Ave. S.");
        }
    }
}
