using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions options) :base(options)
        {
            
        }

        
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    CountryCode = 0001,
                    CountryName = "Nigeria",
                    CountryDescription = "A lovely black country",
                    CourntryShortName = "NIG"
                },
                 new Country
                 {
                     Id = 2,
                     CountryCode = 0111,
                     CountryName = "South Africa",
                     CountryDescription = "A lovely Mixed African country",
                     CourntryShortName = "SA"
                 },
                  new Country
                  {
                      Id = 3,
                      CountryCode = 0011,
                      CountryName = "United State of America",
                      CountryDescription = "A Mixed Race Country",
                      CourntryShortName = "USA"
                  });

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    HotelAddress = "Lagos Nigeria",
                    HotelDescription = "A shortlet hotel",
                    HotelName = "Akans Hotel",
                    CountryId = 1,
                    Rating = "4.2"
                },
                new Hotel
                {
                    Id = 2,
                    HotelAddress = "Loss Angelles",
                    HotelDescription = "a luxury hotel for maximium satisfaction",
                    HotelName = "Lacas Hotel",
                    CountryId = 3,
                    Rating = "5.0"
                },
                new Hotel
                {
                    Id = 3,
                    HotelAddress = "Cape Town",
                    HotelDescription = " Classic hotel with easy life",
                    HotelName = "KwaraKwara Hote;",
                    CountryId = 2,
                    Rating = "5.0"

                });

        }
    }
}
