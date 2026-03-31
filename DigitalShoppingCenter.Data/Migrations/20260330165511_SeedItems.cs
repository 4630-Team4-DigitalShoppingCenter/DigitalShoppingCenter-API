using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DigitalShoppingCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Brand", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Nike", "Ohio State shirt.", "Shirt", 29.99m },
                    { 2, "Nike", "Ohio State shorts.", "Shorts", 44.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
