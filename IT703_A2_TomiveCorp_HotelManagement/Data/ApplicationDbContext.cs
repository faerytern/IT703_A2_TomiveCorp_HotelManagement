using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using IT703_A2_TomiveCorp_HotelManagement.Models;

namespace IT703_A2_TomiveCorp_HotelManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<IT703_A2_TomiveCorp_HotelManagement.Models.JobRole> JobRole { get; set; }
        public DbSet<IT703_A2_TomiveCorp_HotelManagement.Models.Hotel> Hotel { get; set; }
        public DbSet<IT703_A2_TomiveCorp_HotelManagement.Models.Employee> Employee { get; set; }
        public DbSet<IT703_A2_TomiveCorp_HotelManagement.Models.Note> Note { get; set; }
        public DbSet<IT703_A2_TomiveCorp_HotelManagement.Models.Guest> Guest { get; set; }
        public DbSet<IT703_A2_TomiveCorp_HotelManagement.Models.Booking> Booking { get; set; }
        public DbSet<IT703_A2_TomiveCorp_HotelManagement.Models.Bill> Bill { get; set; }
        public DbSet<IT703_A2_TomiveCorp_HotelManagement.Models.Venue> Venue { get; set; }
    }

}