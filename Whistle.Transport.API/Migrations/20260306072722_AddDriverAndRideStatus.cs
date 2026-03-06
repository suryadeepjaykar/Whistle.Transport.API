using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Whistle.Transport.API.Migrations
{
    /// <inheritdoc />
    public partial class AddDriverAndRideStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                table: "Rides",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Rides",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Rides",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Rides");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Rides");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Rides");
        }
    }
}
