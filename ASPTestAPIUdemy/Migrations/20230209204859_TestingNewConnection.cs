using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPTestAPIUdemy.Migrations
{
    /// <inheritdoc />
    public partial class TestingNewConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Adresse", "CountryId", "Name", "Rating" },
                values: new object[] { 4, "1 Street Greatest", 1, "The best hotel", 4.2000000000000002 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
