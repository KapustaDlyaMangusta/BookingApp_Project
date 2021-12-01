using Application.Mappers;
using Application.Repos;
using Dоmain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class MeetingRoomRepos : IMeetingRoomRepos
    {
        private readonly AppDbContext _context;

        public MeetingRoomRepos(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<MeetingRoom>> GetAllMeetings(DateTime meetingDate)
        {
            return await _context.Meetings
                .Where(x => x.MeetingTime.Date == meetingDate)
                .ToListAsync();
        }

        public async Task AddMeeting(MeetingRoom meeting)
        {
            await _context.AddAsync(meeting);
        }


        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
