using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Review_Site.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "TourDuration" },
                values: new object[] { 1000000, 2156 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "TourDuration" },
                values: new object[] { 7000, 6 });
        }
    }
}
