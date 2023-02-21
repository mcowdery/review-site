using Microsoft.EntityFrameworkCore;
using Review_Site.Models;

namespace Review_Site.Data
{
    public class ReviewSiteContext : DbContext
    {
        public DbSet<DestinationModel> Reviews{ get; set; }
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
            modelBuilder.Entity<DestinationModel>().HasData(
               new DestinationModel()
               {
                   Id = 1,
   
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
        }
    }
}
