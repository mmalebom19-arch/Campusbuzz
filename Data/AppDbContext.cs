using Microsoft.EntityFrameworkCore;
using CampusBuzzAPI.Models;

namespace CampusBuzzAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
                new Event { Id = 1, EventTitle = "Hackathon ", Location = "IT Building", TicketPrice = "Free" },
                new Event { Id = 2, EventTitle = "UP Ovuwa", Location = "Amphitheatre", TicketPrice = "R120" },
                new Event { Id = 3, EventTitle = "Tuks Camarata", Location = "Auditorium", TicketPrice = "R250" },
                new Event { Id = 4, EventTitle = "Career Fair", Location = "Main Hall", TicketPrice = "Free" }
            );
        }
    }
}