using Microsoft.EntityFrameworkCore;
using Review_Site.Models;
using System.Runtime;
using static System.Net.WebRequestMethods;

namespace Review_Site.Data
{
    public class ReviewSiteContext : DbContext
    {
        public DbSet<ReviewModel> Reviews{ get; set; }
        public DbSet<DestinationModel> Destinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ReviewSite30;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestinationModel>().HasData(
                new DestinationModel()
                {
                    Id = 1,
                    Name = "Tour of Tokyo",
                    City = "Tokyo",
                    Country = "Japan",
                    Description = "Tokyo, Japan’s busy capital, mixes the ultramodern and the traditional, from neon-lit skyscrapers to historic temples. The opulent Meiji Shinto Shrine is known for its towering gate and surrounding woods. The Imperial Palace sits amid large public gardens. The city's many museums offer exhibits ranging from classical art (in the Tokyo National Museum) to a reconstructed kabuki theater (in the Edo-Tokyo Museum).",
                    ImageURL = "\\Images\\Tokyo1.jpg",
                    ImageList ="\\Images\\Rome1.jpg,\\Images\\Tokyo1.jpg,\\Images\\Mars.jpg",
                    Price = 8000,
                    TourDuration = 10
                },
                new DestinationModel()
                {
                    Id = 2,
                    Name = "Tour of Rome",
                    City = "Rome",
                    Country = "Italy",
                    Description= "Rome was called the “Eternal City” by the ancient Romans because they believed that no matter what happened in the rest of the world, the city of Rome would always remain standing. Exploring the city center by foot surrounded by glorious monuments and colossal remains takes you back in time to the “glory that was Rome”. If you want to see history come to life like never before visit Rome and witness it all aorund you.",
                    Price = 10000,
                    ImageURL = "\\Images\\Rome1.jpg",
                    ImageList = "\\Images\\Rome1.jpg,\\Images\\Tokyo1.jpg,\\Images\\Mars.jpg",
                    TourDuration = 7  
                },
                new DestinationModel()
                {
                    Id = 3,
                    Name = "Tour of Paris",
                    City = "Paris",
                    Country = "France",
                    Description = "Paris, France's capital, is a major European city and a global center for art, fashion, gastronomy and culture. Its 19th-century cityscape is crisscrossed by wide boulevards and the River Seine. Beyond such landmarks as the Eiffel Tower and the 12th-century, Gothic Notre-Dame cathedral, the city is known for its cafe culture and designer boutiques along the Rue du Faubourg Saint-Honoré. ",
                    ImageURL = "\\Images\\Paris1.jpg",
                    ImageList = "\\Images\\Rome1.jpg,\\Images\\Tokyo1.jpg,\\Images\\Mars.jpg",
                    Price = 7000,
                    TourDuration = 6
                },
                new DestinationModel()
                {
                    Id = 4,
                    Name = "Tour of Mars",
                    City = "Random Crater",
                    Country = "Unknown",
                    Description = "See what no man in history has seen. Be the first to discover the Red Planet. This is a once in a lifetime opportunity.  Travel along with the one and only Elon Musk himself on multibillion dollar spaceship x. Its dangerous, its thrilling, its ridiculous. You can be the first to set your foot and leave human mark on the red planet. Do you have what it takes? Mainly the money? Go and Find out! ",
                    ImageURL = "\\Images\\Mars1.jpg",
                    ImageList = "\\Images\\Rome1.jpg,\\Images\\Tokyo1.jpg,\\Images\\Mars.jpg",
                    Price = 1000000,
                    TourDuration = 2156
                });;

            modelBuilder.Entity<ReviewModel>().HasData(
               new ReviewModel()
               {
                   Id = 1,
                   Content = "It's okay",
                   ReviewerName = "Kate Johnson",
                   ImageURL = "\\Images\\Kate.png",
                   Timestamp = DateTime.ParseExact("2002-09-01", "yyyy-MM-dd", null),
                   StarRating = "5",
                   DestinationsId = 1
               },
               new ReviewModel()
               {
                   Id = 2,
                   Content = "It's decent",
                   ReviewerName = "James Olson",
                   ImageURL = "\\Images\\James.png",
                   Timestamp = DateTime.ParseExact("2002-09-01", "yyyy-MM-dd", null),
                   StarRating = "5",
                   DestinationsId = 2
               });
        }
    }
}
