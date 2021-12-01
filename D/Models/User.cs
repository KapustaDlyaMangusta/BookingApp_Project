using Dоmain.Entities;
using Dоmain.Enums;
using System.Collections.Generic;


namespace Dоmain.Models

{
    public class User : BasicEntity
    {
        public string UserName { get; set; }
        public string AvatarUrl { get; set; }
        public RoleOfUser Role { get; set; }
        
        // Identity
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        //  EntityFramework
        public ICollection<WorkingPlaceBooking> WorkingPlaceBookings { get; set; }
        public ICollection<MeetingRoom> BookerMeetings { get; set; }
        public ICollection<MeetingRequiredParticipant> MeetingRequiredParticipants { get; set; }
        public ICollection<MeetingOptionalParticipant> MeetingOptionalParticipant { get; set; }

    }
}
