using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class newoneon1111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LocationMaterials",
                columns: new[] { "Id", "LocationId", "MaterialsId" },
                values: new object[] { -18, -16, -8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocationMaterials",
                keyColumn: "Id",
                keyValue: -18);
        }
    }
}
