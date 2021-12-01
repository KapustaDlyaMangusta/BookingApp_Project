using System;
using System.Collections.Generic;


namespace Dоmain.DTOs
{
    public class MeetingRoomDTO
    {
        public Guid Id { get; set; }

        public DateTime MeetingTime { get; set; }

        public TimeSpan Duration { get; set; }

        public string MeetingTheme { get; set; }

        public UserDTO MeetingOwner { get; set; }

        // EntityFramework
        public ICollection<UserDTO> RequiredParticipants { get; set; }

        public ICollection<UserDTO> OptionalParticipants { get; set; }
    }
}
