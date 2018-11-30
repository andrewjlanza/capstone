using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class newoneon1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Latitude", "Longitude", "weekdayHours" },
                values: new object[] { 28.1381046, -82.7503984, "Monday - Friday, 7am - 4:30pm" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 28.1449662, -82.7722478 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Latitude", "Longitude", "weekdayHours" },
                values: new object[] { 27.342242, -82.494311, "7am - 4:30pm" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 29.333, 82.333 });
        }
    }
}
