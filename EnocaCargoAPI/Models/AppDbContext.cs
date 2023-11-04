using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EnocaCargoAPI.Models
{
    // Veritabanı ile haberleşmeyi sağlayan sınıf
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet veritabanındaki tablolarımızı temsil etmektedir
        public DbSet<Carriers> Carriers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<CarrierConfigurations> CarrierConfigurations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // İlişkiler burada tanımlanacak
        }
    }
}
