using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend_API.Migrations
{
    /// <inheritdoc />
    public partial class AddedBusinessContactFeedbacksSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "BusinessContactDetails",
                columns: table => new
                {
                    BusinessContactDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessMailingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessContactDetails", x => x.BusinessContactDetailsId);
                });

            migrationBuilder.InsertData(
                table: "BusinessContactDetails",
                columns: new[] { "BusinessContactDetailsId", "BusinessEmail", "BusinessMailingAddress", "BusinessName", "BusinessPhone" },
                values: new object[] { 1, "busybusiness@email.com", "42 Wallaby Way, Sydey, Australia", "the business's name LLC", "(123)456-7890" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Category");

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 4,
                column: "CategoryId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "FeedbackId", "CreatedAt", "Description", "Title", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "the contents of the feedback", "first feedback", new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessContactDetails");

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "FeedbackId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Cats");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 2, "Weather" },
                    { 3, "Sports" },
                    { 4, "Food" }
                });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 3,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 4,
                column: "CategoryId",
                value: 4);
        }
    }
}
