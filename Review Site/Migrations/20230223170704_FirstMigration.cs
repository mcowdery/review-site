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
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    DateTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarRating = table.Column<int>(type: "int", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "City", "Country", "Description", "ImageURL", "Name", "Price", "TourDuration" },
                values: new object[,]
                {
                    { 1, "Rome", "Italy", "See famous Colliseum, Spanish Steps, Pantheon, St.Peter's Basilica, Trevi Fountain and much more.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.city-sightseeing.it%2Fhop-on-hop-off-rome%2F&psig=AOvVaw3ZOY9UZJV2tCQR915UXZI2&ust=1677252037140000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCPjg4fH4q_0CFQAAAAAdAAAAABAE", "Tour of Rome", 10000, 7 },
                    { 2, "Tokyo", "Japan", "See Imperial Palace, Hachikō Memorial Statue, Unicorn Gundam Statue, Senso-Ji Temple and so much more", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.getyourguide.com%2Ftokyo-l193%2F&psig=AOvVaw07tvt2cEmWv6F7uisoLXXl&ust=1677251934110000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCMim5sD4q_0CFQAAAAAdAAAAABAE", "Tour of Tokyo", 8000, 10 },
                    { 3, "Paris", "France", "See the Eiffel Tower, Louvre Museum, Arc de Triumphe, Notre Dame Cathedral and more", "https://media.tacdn.com/media/attractions-splice-spp-674x446/0a/32/31/ce.jpg", "Tour of Paris", 7000, 6 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "DateTime", "DestinationId", "ImageURL", "ReviewerName", "StarRating" },
                values: new object[,]
                {
                    { 1, "It's okay", "20140112180244", 1, "https://res.taketours.com/images/640/Edinburgh%20Castle-Edinburgh-Scotland-UK.jpg", "Sergei", 5 },
                    { 2, "It's decent", "20140112180244", 2, "https://media.timeout.com/images/105240237/750/422/image.jpg", "Mat", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_DestinationId",
                table: "Reviews",
                column: "DestinationId");
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
