using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JTrip.API.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepartureTime", "Description", "DiscountPresent", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("d43f97b8-64c5-433b-8de5-436e9a993ebe"), new DateTime(2021, 3, 9, 3, 37, 30, 686, DateTimeKind.Utc).AddTicks(4430), null, "TestDescription", null, null, null, null, 0m, "TestTitle", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("d43f97b8-64c5-433b-8de5-436e9a993ebe"));
        }
    }
}
