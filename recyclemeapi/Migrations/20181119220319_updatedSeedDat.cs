using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class updatedSeedDat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "MaterialType" },
                values: new object[] { -1, "Paper" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "MaterialType" },
                values: new object[] { -2, "Plastic" });

            migrationBuilder.InsertData(
                table: "LocationMaterials",
                columns: new[] { "Id", "LocationId", "MaterialsId" },
                values: new object[] { -1, -1, -1 });

            migrationBuilder.InsertData(
                table: "LocationMaterials",
                columns: new[] { "Id", "LocationId", "MaterialsId" },
                values: new object[] { -2, -1, -2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
