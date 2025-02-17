using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend_API.Migrations
{
    /// <inheritdoc />
    public partial class SiteUserLinkedToContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Content",
                newName: "AuthorId");

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "AuthorId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "AuthorId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 3,
                column: "AuthorId",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 4,
                column: "AuthorId",
                value: "1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Content",
                newName: "Author");

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "Author",
                value: "Author");

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "Author",
                value: "Author");

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 3,
                column: "Author",
                value: "Author");

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 4,
                column: "Author",
                value: "Author");
        }
    }
}
