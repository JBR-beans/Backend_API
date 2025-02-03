using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend_API.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Cats" },
                    { 2, "Weather" },
                    { 3, "Sports" },
                    { 4, "Food" }
                });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "ContentId", "Author", "Body", "CategoryId", "CreatedAt", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Author", "body", 1, new DateTime(2025, 2, 2, 21, 35, 1, 295, DateTimeKind.Local).AddTicks(2942), "1Title", new DateTime(2025, 2, 2, 21, 35, 1, 296, DateTimeKind.Local).AddTicks(9984) },
                    { 2, "Author", "body", 2, new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(268), "2Title", new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(272) },
                    { 3, "Author", "body", 3, new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(274), "3Title", new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(275) },
                    { 4, "Author", "body", 4, new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(277), "4Title", new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(278) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
