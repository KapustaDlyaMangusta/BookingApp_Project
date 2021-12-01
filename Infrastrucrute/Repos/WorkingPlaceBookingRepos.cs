using Application.Repos;
using Dоmain.Enums;
using Dоmain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class WorkingPlaceBookingRepos : IWorkingPlaceBookingRepos
    {
        private readonly AppDbContext _context;

        public WorkingPlaceBookingRepos(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<IList<WorkingPlaceBooking>> GetWorkingPlacesBookings(DateTime working_place_bookingDate)
        {
            return await _context.WorkingPlaceBookings
                .Include(x => x.User)
                .Include(x => x.WorkingPlace)
                .Where(y => y.Date == working_place_bookingDate)
                .ToListAsync();
        }

        public async Task<IList<WorkingPlaceBooking>> GetWorkingPlacesBookingsByUser(Guid userId)
        {
            return await _context.WorkingPlaceBookings
                .Include(x => x.User)
                .Include(x => x.WorkingPlace)
                .Where(x => x.User.Id == userId)
                .ToListAsync();
        }

        public async Task<WorkingPlaceBooking> GetById(Guid id)
        {
            var result = await _context.WorkingPlaceBookings
                .Include(x => x.User)
                .Include(x => x.WorkingPlace)
                .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }


        public async Task AddWorkingPlaceBooking(WorkingPlaceBooking working_place_booking)
        {
            await _context.WorkingPlaceBookings.AddAsync(working_place_booking);
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    } 
}
