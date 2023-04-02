using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EnterpriseApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedEnterpriseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Enterprises",
                columns: new[] { "Id", "Brand", "CreatedDate", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[,]
                {
                    { 1, "DELL G5", new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1559), "unning as admin worked for me after experiencing the same issue.", "Angular Blue Boot", "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/", 19000L, 100, "Angular" },
                    { 2, "DELL G5", new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1585), "unning as admin worked for me after experiencing the same issue.", "Angular Blue Boot", "https://www.pexels.com/photo/white-concrete-2-storey-house-206172/", 19000L, 100, "Angular" },
                    { 3, "Redis", new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1590), "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen", "Core Red Boot", "https://www.pexels.com/photo/palm-trees-at-night-258154/", 18999L, 100, "Boot" },
                    { 4, "Net Core", new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1595), "Running as admin worked for me after experiencing the same issue.", "Core Purple Boot", "ihttps://www.pexels.com/photo/palm-trees-at-night-258154/", 17990L, 100, "Boot" },
                    { 5, "DELL G5", new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1600), "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen", "Angular Blue Boot", "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/", 430000L, 100, "Angular" },
                    { 6, "Net Core", new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1604), "Running as admin worked for me after experiencing the same issue.", "Core Purple Boot", "https://www.pexels.com/photo/palm-trees-at-night-258154/", 17990L, 100, "Boot" },
                    { 7, "DELL G5", new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1609), "Core I5 16gb RAM 256gb SSD 10th Generation 14inch Screen", "Angular Blue Boot", "https://www.pexels.com/photo/palm-trees-at-night-258154/", 430000L, 100, "Angular" },
                    { 8, "Net Core", new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1614), "Running as admin worked for me after experiencing the same issue.", "Core Purple Boot", "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/", 17990L, 100, "Boot" },
                    { 9, "Net Core", new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1619), "Running as admin worked for me after experiencing the same issue.", "Core Purple Boot", "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/\"", 17990L, 100, "Boot" },
                    { 10, "Net Core", new DateTime(2023, 4, 2, 12, 5, 50, 8, DateTimeKind.Local).AddTicks(1624), "Running as admin worked for me after experiencing the same issue.", "Core Purple Boot", "https://www.pexels.com/photo/architecture-beach-blue-chairs-261101/", 17990L, 100, "Boot" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enterprises",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
