using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class addedcoupledozenlocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -18,
                column: "MaterialsId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -16,
                column: "MaterialsId",
                value: -1);

            migrationBuilder.InsertData(
                table: "LocationMaterials",
                columns: new[] { "Id", "LocationId", "MaterialsId" },
                values: new object[,]
                {
                    { -26, -15, -9 },
                    { -31, -1, -4 },
                    { -32, -1, -5 },
                    { -33, -1, -6 },
                    { -25, -15, -5 },
                    { -34, -1, -7 },
                    { -35, -1, -8 },
                    { -36, -1, -9 },
                    { -19, -16, -3 },
                    { -20, -16, -5 },
                    { -21, -16, -8 },
                    { -30, -1, -3 },
                    { -22, -16, -9 },
                    { -24, -15, -3 },
                    { -23, -16, -7 },
                    { -29, -1, -2 }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.769472, -82.630048 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Address", "CenterName", "Latitude", "Longitude", "Zip" },
                values: new object[] { "4300 Haines Rd.", "Grace Lutheran Drop-Off", 27.810599, -82.655398, "33714" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Latitude", "Longitude", "Zip" },
                values: new object[] { 27.806876, -82.694447, "33713" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.71836, -82.68205 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.78592, -82.640488 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.752473, -82.650372 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.730649, -82.645629 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.74549, -82.66848 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.790123, -82.666833 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.795445, -82.704636 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.828215, -82.62371 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.87395, -82.67436 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "CenterName", "City", "Latitude", "Longitude", "PhoneNumber", "Rating", "State", "Zip", "weekdayHours", "weekendHours" },
                values: new object[,]
                {
                    { -33, "3745 9th Ave. N", "St. Petersburg Public Library", "St. Petersburg", 27.78169, -82.684268, "", 4, "FL", "33713", "", "" },
                    { -17, "3940 Keystone Rd.", "Brooker Creek Education Center", "Tarpon Springs", 27.9047092, -82.6720455, "", 4, "FL", "34688", "", "" },
                    { -18, "3940 Keystone Rd.", "A.L. Anderson Park, Between Klosterman Rd. and Tarpon Ave ", "Tarpon Springs", 28.13414, -82.738827, "", 4, "FL", "34689", "", "" },
                    { -19, "4111 Dunn Dr. ", "William E. Dunn Water Reclamation Facility, Off Alt U.S. 19 N", "Palm Harbor", 28.10988, -82.765189, "", 4, "FL", "34683", "", "" },
                    { -20, "2200 East Lake Rd.", "John Chesnut Sr. Park ", "Palm Harbor", 28.087942, -82.702042, "", 4, "FL", "34685", "", "" },
                    { -21, "1825 Curlew Rd. ", "Curlew Retention Pond, Between Belcher Rd. and CR 1 ", "Palm Harbor", 28.049431, -82.752827, "", 4, "FL", "34683", "", "" },
                    { -22, "1940 Ed Eckert Dr. ", "Highlander Park Recycling Site, Across from Highlander Pool ", "Dunedin", 28.036594, -82.777803, "", 4, "FL", "34698", "", "" },
                    { -23, "817 Lake Haven Rd. ", "Lake Haven Recycling Center", "Dunedin", 28.017087, -82.770546, "", 4, "FL", "34698", "", "" },
                    { -24, "3095 McMullen Booth Rd", "Safety Harbor Fire Station 53", "Clearwater", 28.033941, -82.708135, "", 4, "FL", "33761", "", "" },
                    { -25, "1200 Railroad Ave", "Safety Harbor Public Works", "Safety Harbor", 27.999967, -82.69599, "", 4, "FL", "34695", "", "" },
                    { -26, "29582 U.S. 19 N", "North County Service Center,  West side, south of Curlew Rd.", "Clearwater", 28.034406, -82.732479, "", 4, "FL", "33761", "", "" },
                    { -27, "1701 N Hercules Ave.", "Clearwater Solid Waste Facility", "Clearwater", 27.982803, -82.752747, "", 4, "FL", "33765", "", "" },
                    { -29, "1060 Gulf Blvd", "Sand Key Park", "Clearwater", 27.96442, -82.82241, "", 4, "FL", "33767", "", "" },
                    { -30, "1075 Ponce de Leon Blvd.", "John J. Osborne Public Works Building", "Belleair", 27.933655, -82.800926, "", 4, "FL", "33756", "", "" },
                    { -31, "6635 Dr. MLK Jr. St. N", "Fossil Park", "St. Petersburg", 27.82923, -82.64527, "", 4, "FL", "33702", "", "" },
                    { -32, "2331 60th Ave. N", "Northwest Park", "St. Petersburg", 27.79295, -82.715668, "", 4, "FL", "33710", "", "" },
                    { -34, "7000 4th St. S", "Bay Vista Park", "St. Petersburg", 27.704539, -82.641212, "", 4, "FL", "33705", "", "" },
                    { -28, "23106 U.S. 19 N", "Walmart, SE corner of parking lot", "Clearwater", 27.983581, -82.731369, "", 4, "FL", "33765", "", "" }
                });

            migrationBuilder.InsertData(
                table: "LocationMaterials",
                columns: new[] { "Id", "LocationId", "MaterialsId" },
                values: new object[] { -27, -17, -1 });

            migrationBuilder.InsertData(
                table: "LocationMaterials",
                columns: new[] { "Id", "LocationId", "MaterialsId" },
                values: new object[] { -28, -17, -3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.UpdateData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -18,
                column: "MaterialsId",
                value: -8);

            migrationBuilder.UpdateData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -16,
                column: "MaterialsId",
                value: -6);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.342242, -82.494311 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Address", "CenterName", "Latitude", "Longitude", "Zip" },
                values: new object[] { "4364 15th St N", "Grace Lutheran Church Drop-Off", 27.875891, -82.67545, "33703" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Latitude", "Longitude", "Zip" },
                values: new object[] { 27.342242, -82.494311, "34232" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.342242, -82.494311 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.342242, -82.494311 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.909443, -82.495022 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.875891, -82.67545 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.875891, -82.67545 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.875891, -82.67545 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.875891, -82.67545 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.875891, -82.67545 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 27.875891, -82.67545 });
        }
    }
}
