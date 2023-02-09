using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ASPTestAPIUdemy.Data
{
    public class HotelListingDbContext : DbContext
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
                new Country
                {
                    Id = 1,
                    Name = "Canada",
                    ShortName = "CA"
                },
                new Country
                {
                    Id = 2,
                    Name = "USA",
                    ShortName = "US"
                },
                new Country
                {
                    Id = 3,
                    Name = "Mexico",
                    ShortName = "MX"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hotel n1",
                    Adresse = "1 street mcgill",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hotel n2",
                    Adresse = "2 street JFK",
                    CountryId = 2,
                    Rating = 4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hotel n3",
                    Adresse = "3 Street Gumbo",
                    CountryId = 3,
                    Rating = 5
                },
                new Hotel { Id=4, Name="The best hotel", Adresse="1 Street Greatest", Rating=4.2, CountryId=1}
           );
        }
    }
}
