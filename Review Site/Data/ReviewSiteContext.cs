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
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ReviewSite;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestinationModel>().HasData(
                new DestinationModel()
                {
                    Id = 1,
                    Name = "Colleseum",
                    City = "Rome",
                    Country = "Italy",
                    Description= "The Colosseum in Rome, Italy, is a large amphitheater that hosted events like gladiatorial games.",
                    Price = 23.22m,
                    VisitDuration = 60,
                    YearBuilt = 80
                },
                new DestinationModel()
                {
                    Id = 2,
                    Name = "Nara Park",
                    City = "Nara",
                    Country = "Japan",
                    Description = "Nara Park, one of Nara's most famous destinations, is famous for being able to interact with deer that roam in the park. There are various spots in the vicinity, such as the Ukimido Pavilion and Mt. Wakakusa.",
                    Price = 0m,
                    VisitDuration = 60,
                    YearBuilt = 80
                });
            modelBuilder.Entity<ReviewModel>().HasData(
               new ReviewModel()
               {
                   Id = 1,
                   Content = "It's okay",
                   ReviewerName = "Sergei"
               },
               new ReviewModel()
               {
                   Id = 2,
                   Content="It's decent",
                   ReviewerName = "Mat"
               });
        }
    }
}
