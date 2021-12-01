using Dоmain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Behaviour.Room.Query
{
    public class RoomQueryResponse
    {
        public RoomQueryResponse(MeetingRoomDTO meeting)
        {
            Meeting = meeting;
        }

        public MeetingRoomDTO Meeting{ get; private set; }
    }
}
