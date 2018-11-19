using Microsoft.EntityFrameworkCore.Migrations;

namespace recyclemeapi.Migrations
{
    public partial class materialtab2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationMaterials_Locations_LocationId",
                table: "LocationMaterials");

            migrationBuilder.DropColumn(
                name: "LocationsId",
                table: "LocationMaterials");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "LocationMaterials",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationMaterials_Locations_LocationId",
                table: "LocationMaterials",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationMaterials_Locations_LocationId",
                table: "LocationMaterials");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "LocationMaterials",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "LocationsId",
                table: "LocationMaterials",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationMaterials_Locations_LocationId",
                table: "LocationMaterials",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
