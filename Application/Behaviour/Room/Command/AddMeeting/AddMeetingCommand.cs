using Dоmain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Behaviour.Room.Command.AddMeeting
{
    public class AddMeetingCommand : IRequest
    {
        public AddMeetingCommand(MeetingRoom meeting)
        {
            Meeting = meeting;
        }

        public MeetingRoom Meeting { get; set; }
    }
}
