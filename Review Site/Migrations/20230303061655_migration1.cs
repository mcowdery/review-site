using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Review_Site.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TourDuration = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageList = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StarRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Destinations_DestinationsId",
                        column: x => x.DestinationsId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "City", "Country", "Description", "ImageList", "ImageURL", "Name", "Price", "TourDuration" },
                values: new object[,]
                {
                    { 1, "Tokyo", "Japan", "Tokyo, Japan’s busy capital, mixes the ultramodern and the traditional, from neon-lit skyscrapers to historic temples. The opulent Meiji Shinto Shrine is known for its towering gate and surrounding woods. The Imperial Palace sits amid large public gardens. The city's many museums offer exhibits ranging from classical art (in the Tokyo National Museum) to a reconstructed kabuki theater (in the Edo-Tokyo Museum).", "\\Images\\Tokyo11.jpg,\\Images\\Tokyo12.jpg,\\Images\\Tokyo13.jpg,\\Images\\Tokyo14.jpg,\\Images\\Tokyo15.jpg,\\Images\\Tokyo16.jpg,\\Images\\Tokyo17.jpg,\\Images\\Tokyo18.jpg", "\\Images\\Tokyo1.jpg", "Tour of Tokyo", 8000, 10 },
                    { 2, "Rome", "Italy", "Rome was called the “Eternal City” by the ancient Romans because they believed that no matter what happened in the rest of the world, the city of Rome would always remain standing. Exploring the city center by foot surrounded by glorious monuments and colossal remains takes you back in time to the “glory that was Rome”. If you want to see history come to life like never before visit Rome and witness it all aorund you.", "\\Images\\Rome11.jpg,\\Images\\Rome12.jpg,\\Images\\Rome13.jpg,\\Images\\Rome14.jpg,\\Images\\Rome15.jpg,\\Images\\Rome16.jpg,\\Images\\Rome17.jpg,\\Images\\Rome18.jpg", "\\Images\\Rome1.jpg", "Tour of Rome", 10000, 7 },
                    { 3, "Paris", "France", "Paris, France's capital, is a major European city and a global center for art, fashion, gastronomy and culture. Its 19th-century cityscape is crisscrossed by wide boulevards and the River Seine. Beyond such landmarks as the Eiffel Tower and the 12th-century, Gothic Notre-Dame cathedral, the city is known for its cafe culture and designer boutiques along the Rue du Faubourg Saint-Honoré. ", "\\Images\\Paris11.jpg,\\Images\\Paris12.jpg,\\Images\\Paris13.jpg,\\Images\\Paris14.jpg,\\Images\\Paris15.jpg,\\Images\\Paris16.jpg,\\Images\\Paris17.jpg,\\Images\\Paris18.jpg", "\\Images\\Paris1.jpg", "Tour of Paris", 7000, 6 },
                    { 4, "Random Crater", "Unknown", "See what no man in history has seen. Be the first to discover the Red Planet. This is a once in a lifetime opportunity.  Travel along with the one and only Elon Musk himself on multibillion dollar spaceship x. Its dangerous, its thrilling, its ridiculous. You can be the first to set your foot and leave human mark on the red planet. Do you have what it takes? Mainly the money? Go and Find out! ", "\\Images\\Rome1.jpg,\\Images\\Tokyo1.jpg,\\Images\\Mars.jpg", "\\Images\\Mars1.jpg", "Tour of Mars", 1000000, 2156 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "DestinationsId", "ImageURL", "ReviewerName", "StarRating", "Timestamp" },
                values: new object[,]
                {
                    { 1, "It's okay", 1, "\\Images\\Kate.png", "Kate Johnson", "5", new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "It's decent", 2, "\\Images\\James.png", "James Olson", "5", new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_DestinationsId",
                table: "Reviews",
                column: "DestinationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
