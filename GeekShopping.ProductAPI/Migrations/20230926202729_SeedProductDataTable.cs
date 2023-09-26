using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "informatica", "description", "localhost", "name", 2000m },
                    { 3L, "informatica", "description", "localhost", "name", 2000m },
                    { 4L, "informatica", "description", "localhost", "name", 2000m },
                    { 5L, "informatica", "description", "localhost", "name", 2000m },
                    { 6L, "informatica", "description", "localhost", "name", 2000m },
                    { 7L, "informatica", "description", "localhost", "name", 2000m },
                    { 8L, "informatica", "description", "localhost", "name", 2000m },
                    { 9L, "informatica", "description", "localhost", "name", 2000m },
                    { 10L, "informatica", "description", "localhost", "name", 2000m },
                    { 11L, "informatica", "description", "localhost", "name", 2000m },
                    { 12L, "informatica", "description", "localhost", "name", 2000m },
                    { 13L, "informatica", "description", "localhost", "name", 2000m },
                    { 14L, "informatica", "description", "localhost", "name", 2000m },
                    { 15L, "informatica", "description", "localhost", "name", 2000m },
                    { 16L, "informatica", "description", "localhost", "name", 2000m },
                    { 17L, "informatica", "description", "localhost", "name", 2000m },
                    { 18L, "informatica", "description", "localhost", "name", 2000m },
                    { 19L, "informatica", "description", "localhost", "name", 2000m },
                    { 20L, "informatica", "description", "localhost", "name", 2000m },
                    { 21L, "informatica", "description", "localhost", "name", 2000m },
                    { 22L, "informatica", "description", "localhost", "name", 2000m },
                    { 23L, "informatica", "description", "localhost", "name", 2000m },
                    { 24L, "informatica", "description", "localhost", "name", 2000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 24L);
        }
    }
}
