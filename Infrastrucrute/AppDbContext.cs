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

            //БРОНЮВАННЯ МІСЦЯ
            modelBuilder.Entity<WorkingPlaceBooking>()
                .HasOne(x => x.User)
                .WithMany(y => y.WorkingPlaceBookings)
                .HasForeignKey(z => z.UserId);

            modelBuilder.Entity<WorkingPlaceBooking>()
                .HasOne(x => x.WorkingPlace)
                .WithMany(y => y.WorkingPlaceBookings)
                .HasForeignKey(z => z.WorkingPlaceId);

            //БРОНЮВАННЯ МІТІНГ РУМА

            modelBuilder.Entity<MeetingRoom>()
                .HasOne(x => x.MeetingOwner)
                .WithMany(y => y.BookerMeetings);

            //УЧАСНИКИ МІТІНГУ

            modelBuilder.Entity<MeetingRequiredParticipant>()
                .HasOne(x => x.RequiredParticipant)
                .WithMany(y => y.MeetingRequiredParticipants)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MeetingRequiredParticipant>()
                .HasOne(x => x.Meeting)
                .WithMany(y => y.MeetingRequiredParticipants)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MeetingOptionalParticipant>()
                .HasOne(x => x.OptionalParticipant)
                .WithMany(y => y.MeetingOptionalParticipant)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MeetingOptionalParticipant>()
                .HasOne(x => x.Meeting)
                .WithMany(y => y.MeetingOptionalParticipants)
                .OnDelete(DeleteBehavior.NoAction);


        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
    }
}
