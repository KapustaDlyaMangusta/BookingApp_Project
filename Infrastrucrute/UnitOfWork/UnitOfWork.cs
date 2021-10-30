using Application.Mappers;
using Application.Repos;
using Application.UnitOfWork;
using Dоmain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private UserRepos _userRepos;
        private WorkingPlaceRepos _workingplaceRepos;
        private WorkingPlaceBookingRepos _workingplacebookingRepos;
        private MeetingRoomRepos _meetingroomRepos;


        private bool disposed = false;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;

        }
        public IUserRepos<UserDTO> UserReposContext {
            get {
                if (_userRepos == null)
                {
                    _userRepos = new UserRepos(_context);
                }
                return _userRepos;
            }
        }
        public IWorkingPlaceRepos<WorkingPlaceDTO> WorkingPlaceReposContext {
            get {
                if (_workingplaceRepos == null)
                {
                    _workingplaceRepos = new WorkingPlaceRepos(_context);
                }
                return _workingplaceRepos;
            }
        }
        public IWorkingPlaceBookingRepos<WorkingPlaceBookingDTO> WorkingPlaceBookingReposContext {
            get {
                if (_workingplacebookingRepos == null)
                {
                    _workingplacebookingRepos = new WorkingPlaceBookingRepos(_context);
                }
                return _workingplacebookingRepos;
            }
        }
        public IMeetingRoomRepos<MeetingRoomDTO> MeetingRoomReposContext {
            get {
                if (_meetingroomRepos == null)
                {
                    _meetingroomRepos = new MeetingRoomRepos(_context);
                }
                return _meetingroomRepos;
            }
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }


        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposed = true;
            }
        }
       
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
    }
    
}
