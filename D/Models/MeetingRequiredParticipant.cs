using Dоmain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dоmain.Models
{
    public class MeetingRequiredParticipant : BasicEntity
    {

        public Guid ParticipantId { get; set; }
        public User RequiredParticipant { get; set; }

        public Guid MeetingId { get; set; }
        public MeetingRoom Meeting { get; set; }
    }
}
