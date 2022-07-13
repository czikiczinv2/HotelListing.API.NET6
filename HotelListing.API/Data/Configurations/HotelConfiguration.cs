using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
