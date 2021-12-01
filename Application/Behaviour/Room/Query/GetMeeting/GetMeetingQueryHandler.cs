using Application.Mappers;
using Application.Repos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Behaviour.Room.Query.GetMeeting
{
    public class GetMeetingsQueryHandler : IRequestHandler<GetMeetingQuery, IList<RoomQueryResponse>>
    {
        private readonly IMeetingRoomRepos _repos;

        public GetMeetingsQueryHandler(IMeetingRoomRepos repos)
        {
            _repos = repos;
        }

        public async Task<IList<RoomQueryResponse>> Handle(GetMeetingQuery request, CancellationToken cancellationToken)
        {
            var meetings = await _repos.GetAllMeetings(request.Date);
            return meetings.Select(x => new RoomQueryResponse(MeetingRoomMapper.MappingDTO(x))).ToList();
        }
    }
}
