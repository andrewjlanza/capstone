using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class updatedSeedDataa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -12,
                column: "PhoneNumber",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Address", "City", "PhoneNumber", "Zip" },
                values: new object[] { " 1320 5th St. N.", "St. Petersburg", "", "33701" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -6,
                column: "PhoneNumber",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -5,
                column: "PhoneNumber",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -4,
                column: "PhoneNumber",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -3,
                column: "PhoneNumber",
                value: "");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -2,
                column: "PhoneNumber",
                value: "");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -2,
                column: "MaterialType",
                value: "Metal");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -1,
                column: "MaterialType",
                value: "Plastic");

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "MaterialType" },
                values: new object[,]
                {
                    { -3, "Paper" },
                    { -4, "Electronics" },
                    { -5, "Glass" },
                    { -6, "Chemicals" },
                    { -7, "Yard Waste" },
                    { -8, "Cardboard" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -12,
                column: "PhoneNumber",
                value: "(727) 464-7500");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Address", "City", "PhoneNumber", "Zip" },
                values: new object[] { "456 imposter st", "Tampa", "(813) 555-5555", "33629" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -6,
                column: "PhoneNumber",
                value: "(727) 464-7500");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -5,
                column: "PhoneNumber",
                value: "(727) 464-7500");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -4,
                column: "PhoneNumber",
                value: "(727) 464-7500");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -3,
                column: "PhoneNumber",
                value: "(727) 464-7500");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -2,
                column: "PhoneNumber",
                value: "(727) 464-7500");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -2,
                column: "MaterialType",
                value: "Plastic");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -1,
                column: "MaterialType",
                value: "Paper");
        }
    }
}
