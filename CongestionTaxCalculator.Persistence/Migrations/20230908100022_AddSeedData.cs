using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CongestionTaxCalculator.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rules",
                columns: new[] { "Id", "CityName", "EndTime", "StartTime", "TaxValue" },
                values: new object[,]
                {
                    { 1, "Gothenburg", new DateTime(1, 1, 1, 6, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), 8.0 },
                    { 2, "Gothenburg", new DateTime(1, 1, 1, 6, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 6, 30, 0, 0, DateTimeKind.Unspecified), 13.0 },
                    { 3, "Gothenburg", new DateTime(1, 1, 1, 7, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), 18.0 },
                    { 4, "Gothenburg", new DateTime(1, 1, 1, 8, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 13.0 },
                    { 5, "Gothenburg", new DateTime(1, 1, 1, 14, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 8.0 },
                    { 6, "Gothenburg", new DateTime(1, 1, 1, 15, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 13.0 },
                    { 7, "Gothenburg", new DateTime(1, 1, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), 18.0 },
                    { 8, "Gothenburg", new DateTime(1, 1, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 13.0 },
                    { 9, "Gothenburg", new DateTime(1, 1, 1, 18, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 8.0 },
                    { 10, "Gothenburg", new DateTime(1, 1, 1, 5, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 18, 30, 0, 0, DateTimeKind.Unspecified), 0.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rules",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
