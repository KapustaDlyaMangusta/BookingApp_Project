using Dоmain.Entities;
using Dоmain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dоmain.Models

{
    public class User : BasicEntity
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserAvatarUrl { get; set; }
        public RoleOfUser Role { get; set; }
        
        // Не запихуй це в ДТОшку
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        //  EntityFramework
        public ICollection<WorkingPlaceBooking> WorkingPlaceBookings { get; set; }
        public ICollection<MeetingRoom> BookerMeetings { get; set; }
        public ICollection<MeetingRequiredParticipant> MeetingRequiredParticipants { get; set; }
        public ICollection<MeetingOptionalParticipant> MeetingOptionalParticipant { get; set; }

    }
}
