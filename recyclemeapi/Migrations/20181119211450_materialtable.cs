using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class materialtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -12,
                column: "weekendHours",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -11,
                column: "weekendHours",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -10,
                column: "weekendHours",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -9,
                column: "weekendHours",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -8,
                column: "weekendHours",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -12,
                column: "weekendHours",
                value: null);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -11,
                column: "weekendHours",
                value: null);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -10,
                column: "weekendHours",
                value: null);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -9,
                column: "weekendHours",
                value: null);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -8,
                column: "weekendHours",
                value: null);
        }
    }
}
