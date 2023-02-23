using Microsoft.EntityFrameworkCore;
using Review_Site.Models;
using static System.Net.WebRequestMethods;

namespace Review_Site.Data
{
    public class ReviewSiteContext : DbContext
    {
        public DbSet<ReviewModel> Reviews{ get; set; }
        public DbSet<DestinationModel> Destinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ReviewSite11;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestinationModel>().HasData(
                new DestinationModel()
                {
                    Id = 1,
                    Name = "Tour of Rome",
                    City = "Rome",
                    Country = "Italy",
                    Description= "See famous Colliseum, Spanish Steps, Pantheon, St.Peter's Basilica, Trevi Fountain and much more.",
                    Price = 10000,
                    ImageURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.city-sightseeing.it%2Fhop-on-hop-off-rome%2F&psig=AOvVaw3ZOY9UZJV2tCQR915UXZI2&ust=1677252037140000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCPjg4fH4q_0CFQAAAAAdAAAAABAE",
                    TourDuration = 7  
                },
                new DestinationModel()
                {
                    Id = 2,
                    Name = "Tour of Tokyo",
                    City = "Tokyo",
                    Country = "Japan",
                    Description = "See Imperial Palace, Hachikō Memorial Statue, Unicorn Gundam Statue, Senso-Ji Temple and so much more",
                    ImageURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.getyourguide.com%2Ftokyo-l193%2F&psig=AOvVaw07tvt2cEmWv6F7uisoLXXl&ust=1677251934110000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCMim5sD4q_0CFQAAAAAdAAAAABAE",
                    Price = 8000,
                    TourDuration = 10
                },
                new DestinationModel()
                {
                    Id = 3,
                    Name = "Tour of Paris",
                    City = "Paris",
                    Country = "France",
                    Description = "See the Eiffel Tower, Louvre Museum, Arc de Triumphe, Notre Dame Cathedral and more",
                    ImageURL = "https://media.tacdn.com/media/attractions-splice-spp-674x446/0a/32/31/ce.jpg",
                    Price = 7000,
                    TourDuration = 6
                });
            modelBuilder.Entity<ReviewModel>().HasData(
               new ReviewModel()
               {
                   Id = 1,
                   Content = "It's okay",
                   ReviewerName = "Sergei",
                   ImageURL = "https://res.taketours.com/images/640/Edinburgh%20Castle-Edinburgh-Scotland-UK.jpg",
                   DateTime = "20140112180244",
                   StarRating = 5,
                   DestinationId = 1
               },
               new ReviewModel()
               {
                   Id = 2,
                   Content = "It's decent",
                   ReviewerName = "Mat",
                   ImageURL = "https://media.timeout.com/images/105240237/750/422/image.jpg",
                   DateTime = "20140112180244",
                   StarRating = 5,
                   DestinationId = 2
               });
        }
    }
}
