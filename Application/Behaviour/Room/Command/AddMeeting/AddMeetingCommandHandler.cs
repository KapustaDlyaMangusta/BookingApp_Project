using Application.Repos;
using Dоmain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Behaviour.Room.Command.AddMeeting
{
    public class AddMeetingCommandHandler : IRequestHandler<AddMeetingCommand>
    {
        private readonly IMeetingRoomRepos _repos;

        public AddMeetingCommandHandler(IMeetingRoomRepos repos)
        {
            _repos = repos;
        }

        public async Task<Unit> Handle(AddMeetingCommand request, CancellationToken cancellationToken)
        {
            var meetings = await _repos.GetAllMeetings(request.Meeting.MeetingTime.Date);

            if (!meetings.Where(meeting => MeetingTimeConflict(meeting, request.Meeting)).Any())
            {
                await _repos.AddMeeting(request.Meeting);
                await _repos.Commit();
            }
            
            return Unit.Value;
        }

        //ПЕРЕВІРКА НА СПІВПАДІННЯ

        private static bool MeetingTimeConflict(MeetingRoom x, MeetingRoom y)
           => x.MeetingTime.TimeOfDay <= y.MeetingTime.TimeOfDay &&
              y.MeetingTime.TimeOfDay < x.MeetingTime.TimeOfDay + x.Duration ||
              y.MeetingTime.TimeOfDay <= x.MeetingTime.TimeOfDay &&
              x.MeetingTime.TimeOfDay < y.MeetingTime.TimeOfDay + y.Duration;
    }
}
