using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleBookingWebsite.Server.Data.Migrations
{
    public partial class ApplicationDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "AspNetUsers");
        }
    }
}
