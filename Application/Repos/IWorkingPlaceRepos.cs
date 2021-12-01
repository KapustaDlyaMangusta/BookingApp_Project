using Domain.Models;
using Dоmain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repos
{
    public interface IWorkingPlaceRepos
    {
        Task<IList<WorkingPlace>> GetAllWorkingPlaces();
        Task<IList<WorkingPlace>> GetAllBookedWorkingPlaces(DateTime working_place_bookingDate);

        Task<WorkingPlace> GetWorkingPlaceByPlaceNumber(int placeNum);
        Task Commit();
    }
}
