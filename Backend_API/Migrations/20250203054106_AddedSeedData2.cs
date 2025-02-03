using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend_API.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 21, 35, 1, 295, DateTimeKind.Local).AddTicks(2942), new DateTime(2025, 2, 2, 21, 35, 1, 296, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(268), new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(274), new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(277), new DateTime(2025, 2, 2, 21, 35, 1, 297, DateTimeKind.Local).AddTicks(278) });
        }
    }
}
