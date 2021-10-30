using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repos;
using Dоmain.DTOs;

namespace Application.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepos<UserDTO> UserReposContext { get; }
        IWorkingPlaceRepos<WorkingPlaceDTO> WorkingPlaceReposContext { get; }
        IWorkingPlaceBookingRepos<WorkingPlaceBookingDTO> WorkingPlaceBookingReposContext { get; }
        IMeetingRoomRepos<MeetingRoomDTO> MeetingRoomReposContext { get; }
        Task Commit();
    }
}





