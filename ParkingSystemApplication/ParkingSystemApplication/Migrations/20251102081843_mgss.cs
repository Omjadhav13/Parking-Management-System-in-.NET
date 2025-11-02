using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingSystemApplication.Migrations
{
    /// <inheritdoc />
    public partial class mgss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParkingFee",
                table: "Vehicles");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_SlotId",
                table: "Vehicles",
                column: "SlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_ParkingSlots_SlotId",
                table: "Vehicles",
                column: "SlotId",
                principalTable: "ParkingSlots",
                principalColumn: "SlotId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_ParkingSlots_SlotId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_SlotId",
                table: "Vehicles");

            migrationBuilder.AddColumn<decimal>(
                name: "ParkingFee",
                table: "Vehicles",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
