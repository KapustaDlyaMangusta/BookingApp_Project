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
    public class WorkingPlaceRepos : IWorkingPlaceRepos<WorkingPlaceDTO>
    {
        private readonly AppDbContext _context;

        public WorkingPlaceRepos(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<WorkingPlaceDTO>> GetAllWorkingPlaces()
        {
            return await _context.WorkingPlaces
                .Select(x => WorkingPlaceMapper.MappingDTO(x))
                .ToListAsync();
        }

        public async Task<IList<WorkingPlaceDTO>> GetAllBookedWorkingPlaces(DateTime working_place_bookingDate)
        {
            var workPlaces = await _context.WorkingPlaces
                .Include(x => x.WorkingPlaceBookings.Where(x => x.Date == working_place_bookingDate))
                .Where(x => (x.WorkingPlaceBookings.Count == 1 &&
                    (x.WorkingPlaceBookings.First().Type == BookingType.FullDay ||
                    x.WorkingPlaceBookings.First().Type == BookingType.ConstantBooking)) ||
                    x.WorkingPlaceBookings.Count == 2)
                .ToListAsync();

            return workPlaces.Where(x => x.WorkingPlaceBookings.Any())
                .Select(x => WorkingPlaceMapper.MappingDTO(x))
                .ToList();
        }

        public async Task<IList<WorkingPlaceDTO>> GetAllAvailableWorkingPlaces(DateTime working_place_bookingDate)
        {
            return await _context.WorkingPlaces
                   .Include(x => x.WorkingPlaceBookings.Where(x => x.Date == working_place_bookingDate))
                   .Where(x => !((x.WorkingPlaceBookings.Count == 1 &&
                       (x.WorkingPlaceBookings.First().Type == BookingType.FullDay ||
                       x.WorkingPlaceBookings.First().Type == BookingType.ConstantBooking)) ||
                       x.WorkingPlaceBookings.Count == 2))
                   .Select(x => WorkingPlaceMapper.MappingDTO(x))
                   .ToListAsync();
        }

        public async Task<WorkingPlaceDTO> FetchWorkingPlaceById(long working_placeId)
        {
            var working_place = await _context.WorkingPlaces
                .Include(x => x.WorkingPlaceBookings)
                .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == working_placeId);

            return WorkingPlaceMapper.MappingDTO(working_place);
        }

        public void UpdateWorkingPlaces(WorkingPlaceDTO working_place)
        {
            _context.WorkingPlaces.Update(WorkingPlaceMapper.MappingModel(working_place));
        }
    }
}
