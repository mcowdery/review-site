using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Review_Site.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageList",
                value: "\\Images\\Rome11.jpg,\\Images\\Rome12.jpg,\\Images\\Rome13.jpg,\\Images\\Rome14.jpg,\\Images\\Rome15.jpg,\\Images\\Rome16.jpg,\\Images\\Rome17.jpg,\\Images\\Rome18.jpg,");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageList",
                value: "\\Images\\Rome1.jpg,\\Images\\Tokyo1.jpg,\\Images\\Mars.jpg");
        }
    }
}
