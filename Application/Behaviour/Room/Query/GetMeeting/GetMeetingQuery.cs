using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Behaviour.Room.Query.GetMeeting
{
    public class GetMeetingQuery : IRequest<IList<RoomQueryResponse>>
    {
        public GetMeetingQuery(DateTime date)
        {
            Date = date;
        }

        public DateTime Date { get; private set; }
    }
}
