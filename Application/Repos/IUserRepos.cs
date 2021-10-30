using Dоmain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repos
{
    public interface IUserRepos<T> where T : class
    {
        
        Task<IList<T>> GetAllUsers();

        Task<T> FindUserById(long userId);

        Task AddUser(T userDTO);
    }
}
