using Application.Mappers;
using Application.Repos;
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
    public class WorkingPlaceBookingRepos : IWorkingPlaceBookingRepos<WorkingPlaceBookingDTO>
    {
        private readonly AppDbContext _context;

        public WorkingPlaceBookingRepos(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<WorkingPlaceBookingDTO[]> GetWorkingPlacesBookings(DateTime working_place_bookingDate)
        {
            return await _context.WorkingPlaceBookings
                .Where(x => x.Date == working_place_bookingDate)
                .Select(x => WorkingPlaceBookingMapper.MappingDTO(x))
                .ToArrayAsync();
        }

        public async Task<WorkingPlaceBookingDTO[]> GetPendingWorkingPlacesBookings()
        {
            return await _context.WorkingPlaceBookings
                .Where(x => x.Status == BookingStatuses.Pending)
                .Select(x => WorkingPlaceBookingMapper.MappingDTO(x))
                .ToArrayAsync();
        }

        public async Task<WorkingPlaceBookingDTO[]> GetWorkingPlacesBookingsByUser(long userId)
        {
            return await _context.WorkingPlaceBookings
                .Include(x => x.User)
                .Where(x => x.User.Id == userId)
                .Select(x => WorkingPlaceBookingMapper.MappingDTO(x))
                .ToArrayAsync();
        }

        public async Task<WorkingPlaceBookingDTO> FetchById(long id)
        {
            var result = await _context.WorkingPlaceBookings
                .Include(x => x.User)
                .Include(x => x.WorkingPlace)
                .FirstOrDefaultAsync(x => x.Id == id);

            return WorkingPlaceBookingMapper.MappingDTO(result);
        }

        public void RemoveWorkingPlaceBooking(long id)
        {
            _context.Remove(id);
        }

        public async Task AddWorkingPlaceBooking(WorkingPlaceBookingDTO working_place_bookingDTO)
        {
            await _context.WorkingPlaceBookings.AddAsync(WorkingPlaceBookingMapper.MappingModel(working_place_bookingDTO));
        }

        public void UpdateWorkingPlaceBooking(WorkingPlaceBookingDTO working_place_bookingDTO)
        {
            var working_place_bookingModel = WorkingPlaceBookingMapper.MappingModel(working_place_bookingDTO);
            _context.WorkingPlaceBookings.Update(working_place_bookingModel);
        }
    } 
}
