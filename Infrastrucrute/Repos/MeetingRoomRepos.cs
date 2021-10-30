using Application.Mappers;
using Application.Repos;
using Dоmain.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class MeetingRoomRepos : IMeetingRoomRepos<MeetingRoomDTO>
    {
        private readonly AppDbContext _context;

        public MeetingRoomRepos(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<MeetingRoomDTO>> GetAllMeetings(DateTime meetingDate)
        {
            return await _context.Meetings
                .Where(x => x.MeetingTime.Date == meetingDate)
                .Select(x => MeetingRoomMapper.MappingDTO(x))
                .ToListAsync();
        }

        public async Task<MeetingRoomDTO> FindMeetingById(long meetingId)
        {
            return MeetingRoomMapper.MappingDTO(await _context.Meetings.FindAsync(meetingId));
        }

        public async Task AddMeeting(MeetingRoomDTO meetingDto)
        {
            await _context.AddAsync(MeetingRoomMapper.MappingModel(meetingDto));
        }

        public async Task RemoveMeeting(long meetingId)
        {
            var meeting = await _context.Meetings.FindAsync(meetingId);
            _context.Remove(meeting);
        }

        public void UpdateMeeting(MeetingRoomDTO meetingDto)
        {
            _context.Update(MeetingRoomMapper.MappingModel(meetingDto));
        }
    }
}
