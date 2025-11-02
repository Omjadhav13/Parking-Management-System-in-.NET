using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ParkingSystemApplication.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options ) :base (options)
        {
            
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<ParkingSlot> ParkingSlots { get; set; }

    }
}
