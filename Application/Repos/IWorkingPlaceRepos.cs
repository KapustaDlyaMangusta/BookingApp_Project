using Dоmain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repos
{
    public interface IWorkingPlaceRepos<T> where T : class
    {
        Task<IList<T>> GetAllWorkingPlaces();

        Task<IList<T>> GetAllBookedWorkingPlaces(DateTime working_place_bookingDate);

        Task<IList<T>> GetAllAvailableWorkingPlaces(DateTime working_place_bookingDate);

        Task<T> FetchWorkingPlaceById(long working_placeId);
        void UpdateWorkingPlaces(T working_place);
    }
}
