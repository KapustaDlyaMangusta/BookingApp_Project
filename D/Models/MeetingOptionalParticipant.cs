﻿
using Dоmain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dоmain.Models
{
    public class MeetingOptionalParticipant : BasicEntity
    {
        
        public long ParticipantId { get; set; }
        public User OptionalParticipant { get; set; }

        public long MeetingId { get; set; }
        public MeetingRoom Meeting { get; set; }
    }
}
