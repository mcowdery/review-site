using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Review_Site.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Discover Tokyo at your own pace on this 4- or 8-hour private, custom tour with guide. Design a tour that’s perfect for your interests. There’s a world of options, including the outer fish market at Tsukiji, the city’s temples and shrines, shopping excursions and food or sake tours. Your private custom tour includes a guide, entrance fees at select attractions, snacks, round-trip transport from your hotel with meet-and-greet and a car (for the private transfer option), or public transport (for the public transfer) and optional lunch (for the full-day tour).");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "See Imperial Palace, Hachikō Memorial Statue, Unicorn Gundam Statue, Senso-Ji Temple and so much more");
        }
    }
}
