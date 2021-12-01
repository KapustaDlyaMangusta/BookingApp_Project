using Dоmain.DTOs;
using Dоmain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repos
{
    public interface IMeetingRoomRepos
    { 
        Task<IList<MeetingRoom>> GetAllMeetings(DateTime meetingTime);

        Task AddMeeting(MeetingRoom meeting);

        Task Commit();
    }
}
