using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Review_Site.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
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
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DestinationModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Destinations_Destinations_DestinationModelId",
                        column: x => x.DestinationModelId,
                        principalTable: "Destinations",
                        principalColumn: "Id");
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
                    DateTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "City", "Country", "Description", "DestinationModelId", "Name", "Price", "TourDuration" },
                values: new object[,]
                {
                    { 1, "London, Edinborough, Dublin, Newport", "England, Scotland, Whales,Ireland", "The Colosseum in Rome, Italy, is a large amphitheater that hosted events like gladiatorial games.", null, "UK Tour", 10000m, 10 },
                    { 2, "Nara, Tokyo, Osaka, Kyoto", "Japan", "Nara Park, one of Nara's most famous destinations, is famous for being able to interact with deer that roam in the park. There are various spots in the vicinity, such as the Ukimido Pavilion and Mt. Wakakusa.", null, "Tour of Japan", 8000m, 21 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "DateTime", "ImageURL", "ReviewerName", "StarRating" },
                values: new object[,]
                {
                    { 1, "It's okay", "20140112180244", "https://res.taketours.com/images/640/Edinburgh%20Castle-Edinburgh-Scotland-UK.jpg", "Sergei", 5 },
                    { 2, "It's decent", "20140112180244", "https://media.timeout.com/images/105240237/750/422/image.jpg", "Mat", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_DestinationModelId",
                table: "Destinations",
                column: "DestinationModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
