using AirportV1.Models;
using Microsoft.EntityFrameworkCore;

namespace AirportV1.Database
{
    public class FlightDbContext : DbContext
    {

        protected readonly IConfiguration Configuration;

        public FlightDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Flight> Flight { get; set; }
    }
}
