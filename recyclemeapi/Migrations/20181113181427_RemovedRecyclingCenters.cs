using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace recyclemeapi.Migrations
{
    public partial class RemovedRecyclingCenters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_RecyclingCenter_RecyclingCenterId",
                table: "Locations");

            migrationBuilder.DropTable(
                name: "RecyclingCenter");

            migrationBuilder.DropIndex(
                name: "IX_Locations_RecyclingCenterId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "RecyclingCenterId",
                table: "Locations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecyclingCenterId",
                table: "Locations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RecyclingCenter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Brand = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecyclingCenter", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_RecyclingCenterId",
                table: "Locations",
                column: "RecyclingCenterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_RecyclingCenter_RecyclingCenterId",
                table: "Locations",
                column: "RecyclingCenterId",
                principalTable: "RecyclingCenter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
