using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country()
                {
                    Id = 1,
                    Name ="Peru",
                    ShortName ="PE"
                },
                new Country()
                {
                    Id = 2,
                    Name = "Germany",
                    ShortName = "DE"
                },
                new Country()
                {
                    Id = 3,
                    Name = "Poland",
                    ShortName = "PL"
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    Id = 1,
                    Name = "Vienna",
                    Address = "Bielsko-Biala",
                    CountryId = 3,
                    Rating = 4,
                    
                },
                new Hotel()
                {
                    Id = 2,
                    Name = "Grand Hotel Downtown",
                    Address = "Frankfurt",
                    CountryId = 2,
                    Rating = 4,

                }
                );

        }
    }
}
