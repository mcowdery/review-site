using Microsoft.EntityFrameworkCore;
using Review_Site.Models;

namespace Review_Site.Data
{
    public class ReviewSiteContext : DbContext
    {
        public DbSet<ReviewModel> Reviews{ get; set; }
        public DbSet<DestinationModel> Destinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ReviewSite10;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestinationModel>().HasData(
                new DestinationModel()
                {
                    Id = 1,
                    Name = "UK Tour",
                    City = "London, Edinborough, Dublin, Newport",
                    Country = "England, Scotland, Whales,Ireland",
                    Description= "The Colosseum in Rome, Italy, is a large amphitheater that hosted events like gladiatorial games.",
                    Price = 10000m,
                    TourDuration = 10                
                },
                new DestinationModel()
                {
                    Id = 2,
                    Name = "Tour of Japan",
                    City = "Nara, Tokyo, Osaka, Kyoto",
                    Country = "Japan",
                    Description = "Nara Park, one of Nara's most famous destinations, is famous for being able to interact with deer that roam in the park. There are various spots in the vicinity, such as the Ukimido Pavilion and Mt. Wakakusa.",
                    Price = 8000m,
                    TourDuration = 21
                });
            modelBuilder.Entity<ReviewModel>().HasData(
               new ReviewModel()
               {
                   Id = 1,
                   Content = "It's okay",
                   ReviewerName = "Sergei",
                   ImageURL = "https://res.taketours.com/images/640/Edinburgh%20Castle-Edinburgh-Scotland-UK.jpg", 
                   DateTime = "20140112180244",
                   StarRating = 5
               },
               new ReviewModel()
               {
                   Id = 2,
                   Content="It's decent",
                   ReviewerName = "Mat",
                   ImageURL = "https://media.timeout.com/images/105240237/750/422/image.jpg",
                   DateTime = "20140112180244",
                   StarRating = 5
               });
        }
    }
}
