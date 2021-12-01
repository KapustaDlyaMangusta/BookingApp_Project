using Application.Mappers;
using Application.Repos;
using Domain.Models;
using Dоmain.DTOs;
using Dоmain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class WorkingPlaceRepos : IWorkingPlaceRepos
    {
        private readonly AppDbContext _context;

        public WorkingPlaceRepos(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IList<WorkingPlace>> GetAllWorkingPlaces()
        {
            return await _context.WorkingPlaces.ToListAsync();
        }

        public async Task<IList<WorkingPlace>> GetAllBookedWorkingPlaces(DateTime working_place_bookingDate)
        {
            var workPlaces = await _context.WorkingPlaces
                .Include(x => x.WorkingPlaceBookings.Where(x => x.Date == working_place_bookingDate))
                .Where(x => (x.WorkingPlaceBookings.Count == 1 &&
                    (x.WorkingPlaceBookings.First().Type == BookingType.FullDay ||
                    x.WorkingPlaceBookings.First().Type == BookingType.ConstantBooking)) ||
                    x.WorkingPlaceBookings.Count == 2)
                .ToListAsync();

            return workPlaces.Where(x => x.WorkingPlaceBookings.Any()).ToList();
        }

        public async Task<WorkingPlace> GetWorkingPlaceByPlaceNumber(int placeNum)
        {
            return await _context.WorkingPlaces
                .Include(x => x.WorkingPlaceBookings)
                .FirstOrDefaultAsync(x => x.NumPlace == placeNum);
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
