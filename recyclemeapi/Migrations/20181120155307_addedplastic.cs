using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class addedplastic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -1,
                column: "MaterialType",
                value: "Plastic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: -1,
                column: "MaterialType",
                value: "");
        }
    }
}
