using Microsoft.EntityFrameworkCore;

namespace ASPTestAPIUdemy.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
