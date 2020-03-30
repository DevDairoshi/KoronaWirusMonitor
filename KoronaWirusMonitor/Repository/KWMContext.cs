using KoronaWirusMonitor.Models;
using Microsoft.EntityFrameworkCore;

namespace KoronaWirusMonitor.Repository
{
    public class KWMContext : DbContext
    {
        public KWMContext(DbContextOptions<KWMContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        
        public DbSet<KoronaWirusMonitor.Models.Country> Country { get; set; }
    }
}
