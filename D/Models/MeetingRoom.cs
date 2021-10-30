using Dоmain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dоmain.Models
{
    public class MeetingRoom : BasicEntity
    {
        public DateTime MeetingTime { get; set; }
        public string MeetingTheme { get; set; }

        // Entity Framework
        public User Booker { get; set; }

        public ICollection<MeetingRequiredParticipant> MeetingRequiredParticipants { get; set; }

        public ICollection<MeetingOptionalParticipant> MeetingOptionalParticipants { get; set; }

    }
}
