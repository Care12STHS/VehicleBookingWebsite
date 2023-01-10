using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleBookingWebsite.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Colour", "LicensePlateNumber", "PassengerCapacity", "StaffIDId", "VehicleTypeIDId", "Year" },
                values: new object[] { 1, "Toyota", "Black", "SMC1234C", 4, null, null, 2023 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Colour", "LicensePlateNumber", "PassengerCapacity", "StaffIDId", "VehicleTypeIDId", "Year" },
                values: new object[] { 2, "Mercedes-Benz CLA-Class Coupe", "Red", "SMC5678C", 4, null, null, 2023 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
