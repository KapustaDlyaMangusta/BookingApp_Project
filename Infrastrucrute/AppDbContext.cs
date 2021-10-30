using Domain.Models;
using Dоmain.DTOs;
using Dоmain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<WorkingPlaceBooking> WorkingPlaceBookings { get; set; }

        public DbSet<MeetingRoom> Meetings { get; set; }

        public DbSet<WorkingPlace> WorkingPlaces { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(a => a.Id);
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
    }
}
