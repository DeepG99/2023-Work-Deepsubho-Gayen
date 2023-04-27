using Microsoft.EntityFrameworkCore;

namespace RailwayReservationSystem.Models
{
    public class RailwayContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public RailwayContext(DbContextOptions<RailwayContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment>Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Train> Trains { get; set; }
    }
}
