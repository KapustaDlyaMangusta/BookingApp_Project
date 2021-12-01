using Dоmain.DTOs;
using Dоmain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repos
{
    public interface IWorkingPlaceBookingRepos
    {
        Task<IList<WorkingPlaceBooking>> GetWorkingPlacesBookings(DateTime working_place_bookingDate);


        Task<IList<WorkingPlaceBooking>> GetWorkingPlacesBookingsByUser(Guid userId);

        Task<WorkingPlaceBooking> GetById(Guid id);

        Task AddWorkingPlaceBooking(WorkingPlaceBooking working_place_booking);

        Task Commit();
    }
}
