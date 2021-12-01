using Application.Repos;
using Dоmain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Infrastructure.Repos
{
    public class UserRepos : IUserRepos
    {
        private readonly AppDbContext _context;

        public UserRepos(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<User>> GetAllUsers()
        {
            return await _context.Users
                .ToListAsync();
        }
        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
