using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class addedlocationmatsandmats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemsAccepted",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Recycles",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -2,
                column: "LocationId",
                value: -2);

            migrationBuilder.InsertData(
                table: "LocationMaterials",
                columns: new[] { "Id", "LocationId", "MaterialsId" },
                values: new object[,]
                {
                    { -3, -3, -3 },
                    { -12, -12, -3 },
                    { -11, -11, -2 },
                    { -10, -10, -1 },
                    { -4, -4, -4 },
                    { -5, -5, -5 },
                    { -6, -6, -6 },
                    { -8, -8, -8 }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Address", "CenterName", "Zip" },
                values: new object[] { "4364 15th St N", "Grace Lutheran Church Drop-Off", "33703" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Address", "CenterName", "City", "PhoneNumber" },
                values: new object[] { "4515 38th Ave N", "Clearview United Methodist Drop-Off", "St. Petersburg", "" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Address", "CenterName", "City", "PhoneNumber", "Zip" },
                values: new object[] { "3802 54th Ave. S.", "Pinellas Bayway Drop-Off", "St. Petersburg", "", "33711" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Address", "CenterName", "City", "PhoneNumber", "Zip" },
                values: new object[] { " 1320 5th St. N.", "Crescent Lake Drop-Off", "St. Petersburg", "", "33701" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Address", "CenterName", "PhoneNumber", "Zip", "weekdayHours" },
                values: new object[] { " 1111 18th Ave. S.", "Enoch Davis Recreation Center", "(727) 893-7134", "33705", "Monday - Tuesday 8:00 am - 8-00 pm  Wednesday 8:00 am - 5:00 pm. Thursday - Friday 8:00 am - 8:00 pm" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "weekdayHours", "weekendHours" },
                values: new object[] { "Monday-Friday, 9 a.m. to 5:30 p.m.", "Saturday and Sunday, 8 a.m. to 5:30 p.m." });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "CenterName", "City", "Latitude", "Longitude", "PhoneNumber", "Rating", "State", "Zip", "weekdayHours", "weekendHours" },
                values: new object[,]
                {
                    { -14, "300 2nd Ave SE", "Municipal Marina Drop-Off", "St. Petersburg", 27.342242, -82.494311, "", 4, "FL", "33701", "", "" },
                    { -13, "300 2nd Ave SE", "Municipal Marina Drop-Off", "St. Petersburg", 27.342242, -82.494311, "", 4, "FL", "33701", "", "" }
                });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -1,
                column: "MaterialType",
                value: "");

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "MaterialType" },
                values: new object[] { -9, "Aluminum Cans" });

            migrationBuilder.InsertData(
                table: "LocationMaterials",
                columns: new[] { "Id", "LocationId", "MaterialsId" },
                values: new object[] { -13, -13, -4 });

            migrationBuilder.InsertData(
                table: "LocationMaterials",
                columns: new[] { "Id", "LocationId", "MaterialsId" },
                values: new object[] { -14, -14, -5 });

            migrationBuilder.InsertData(
                table: "LocationMaterials",
                columns: new[] { "Id", "LocationId", "MaterialsId" },
                values: new object[] { -9, -9, -9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.AddColumn<int>(
                name: "ItemsAccepted",
                table: "Locations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Recycles",
                table: "Locations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -2,
                column: "LocationId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Address", "CenterName", "ItemsAccepted", "Recycles", "Zip" },
                values: new object[] { "1000 62nd Ave. N.E.", "Pinellas County Recycling & Brush Site", 3, 3, "33702" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Address", "CenterName", "City", "PhoneNumber" },
                values: new object[] { "789 false ave", "Manatee County Solid Waste", "Sarasota", "(941) 222-2222" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Address", "CenterName", "City", "PhoneNumber", "Zip" },
                values: new object[] { "789 false ave", "Manatee County Solid Waste", "Sarasota", "(941) 222-2222", "34232" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Address", "CenterName", "City", "PhoneNumber", "Zip" },
                values: new object[] { "789 false ave", "Manatee County Solid Waste", "Sarasota", "(941) 222-2222", "34232" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Address", "CenterName", "ItemsAccepted", "PhoneNumber", "Recycles", "Zip", "weekdayHours" },
                values: new object[] { " 1320 5th St. N.", "Hillsborough County Solid Waste", 1, "", 1, "33701", "" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "ItemsAccepted", "Recycles" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "ItemsAccepted", "Recycles" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "ItemsAccepted", "Recycles" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "ItemsAccepted", "Recycles" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "ItemsAccepted", "Recycles" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "ItemsAccepted", "Recycles", "weekdayHours", "weekendHours" },
                values: new object[] { 3, 3, null, null });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -1,
                column: "MaterialType",
                value: "Plastic");
        }
    }
}
