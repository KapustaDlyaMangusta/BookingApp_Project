using Application.Mappers;
using Application.Repos;
using Dоmain.DTOs;
using Dоmain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class UserRepos : IUserRepos<UserDTO>
    {
        private readonly AppDbContext _context;

        public UserRepos(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IList<UserDTO>> GetAllUsers()
        {
            return await _context.Users.Include(x => x.WorkingPlaceBookings)
                .Select(x => UserMapper.MappingDTO(x))
                .ToArrayAsync();
        }

        public async Task<UserDTO> FindUserById(long userId)
        {
            var user = await _context.Users
                .Include(x => x.WorkingPlaceBookings)
                .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == userId);

            return UserMapper.MappingDTO(user);
        }

        public async Task AddUser(UserDTO userDTO)
        {
            await _context.Users.AddAsync(UserMapper.MappingModel(userDTO));
        }
    }
}
