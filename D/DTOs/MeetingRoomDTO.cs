using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dоmain.DTOs
{
    public class MeetingRoomDTO
    {
        public long Id { get; set; }

        public DateTime MeetingTime { get; set; }

        public string MeetingTheme { get; set; }

        public UserDTO Booker { get; set; }

        // EntityFramework
        public ICollection<UserDTO> RequiredParticipants { get; set; }

        public ICollection<UserDTO> OptionalParticipants { get; set; }
    }
}
