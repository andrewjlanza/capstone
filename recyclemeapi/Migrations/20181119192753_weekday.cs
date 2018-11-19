using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class weekday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Hours",
                table: "Locations",
                newName: "weekendHours");

            migrationBuilder.AddColumn<string>(
                name: "weekdayHours",
                table: "Locations",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "weekdayHours", "weekendHours" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "weekdayHours", "weekendHours" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "weekdayHours", "weekendHours" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "weekdayHours", "weekendHours" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "weekdayHours", "weekendHours" },
                values: new object[] { "", null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "weekdayHours", "weekendHours" },
                values: new object[] { "Monday-Friday, 9 a.m. to 5:30 p.m.", "Saturday and Sunday, 8 a.m. to 5:30 p.m." });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "weekdayHours", "weekendHours" },
                values: new object[] { "Monday-Friday, 9 a.m. to 5:30 p.m.", "Saturday and Sunday, 8 a.m. to 5:30 p.m." });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "weekdayHours", "weekendHours" },
                values: new object[] { "Monday-Friday, 9 a.m. to 5:30 p.m.", "Saturday and Sunday, 8 a.m. to 5:30 p.m." });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "weekdayHours", "weekendHours" },
                values: new object[] { "Monday-Friday, 9 a.m. to 5:30 p.m.", "Saturday and Sunday, 8 a.m. to 5:30 p.m." });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "weekdayHours", "weekendHours" },
                values: new object[] { "Monday-Friday, 9 a.m. to 5:30 p.m.", "Saturday and Sunday, 8 a.m. to 5:30 p.m." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "weekdayHours",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "weekendHours",
                table: "Locations",
                newName: "Hours");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -12,
                column: "Hours",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -11,
                column: "Hours",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -10,
                column: "Hours",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -9,
                column: "Hours",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -8,
                column: "Hours",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -6,
                column: "Hours",
                value: "Monday-Friday, 9 a.m. to 5:30 p.m.,Saturday and Sunday, 8 a.m. to 5:30 p.m.");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -5,
                column: "Hours",
                value: "Monday-Friday, 9 a.m. to 5:30 p.m.,Saturday and Sunday, 8 a.m. to 5:30 p.m.");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -4,
                column: "Hours",
                value: "Monday-Friday, 9 a.m. to 5:30 p.m.,Saturday and Sunday, 8 a.m. to 5:30 p.m.");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -3,
                column: "Hours",
                value: "Monday-Friday, 9 a.m. to 5:30 p.m.,Saturday and Sunday, 8 a.m. to 5:30 p.m.");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -2,
                column: "Hours",
                value: "Monday-Friday, 9 a.m. to 5:30 p.m.,Saturday and Sunday, 8 a.m. to 5:30 p.m.");
        }
    }
}
