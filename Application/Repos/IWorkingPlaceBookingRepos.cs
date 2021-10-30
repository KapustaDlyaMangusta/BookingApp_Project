using Dоmain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repos
{
    public interface IWorkingPlaceBookingRepos<T> where T : class
    {
        Task<T[]> GetWorkingPlacesBookings(DateTime working_place_bookingDate);

        Task<T[]> GetPendingWorkingPlacesBookings();

        Task<T[]> GetWorkingPlacesBookingsByUser(long userId);

        Task<T> FetchById(long id);

        Task AddWorkingPlaceBooking(T working_place_bookingDTO);

        void RemoveWorkingPlaceBooking(long id);

        void UpdateWorkingPlaceBooking(T working_place_bookingDTO);
    }
}
