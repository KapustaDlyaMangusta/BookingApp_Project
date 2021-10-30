using Dоmain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repos
{
    public interface IMeetingRoomRepos<T> where T : class
    { 
        Task<IList<T>> GetAllMeetings(DateTime meetingTime);

        Task<T> FindMeetingById(long meetingId);

        Task AddMeeting(T meeting);

        Task RemoveMeeting(long meetingId);

        void UpdateMeeting(T meeting);
    }
}
