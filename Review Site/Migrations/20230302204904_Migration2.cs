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
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageURL", "ReviewerName" },
                values: new object[] { "\\Images\\Kate.png", "Kate Johnson" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageURL", "ReviewerName" },
                values: new object[] { "\\Images\\James.png", "James Olson" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageURL", "ReviewerName" },
                values: new object[] { "https://res.taketours.com/images/640/Edinburgh%20Castle-Edinburgh-Scotland-UK.jpg", "Sergei" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageURL", "ReviewerName" },
                values: new object[] { "https://media.timeout.com/images/105240237/750/422/image.jpg", "Mat" });
        }
    }
}
