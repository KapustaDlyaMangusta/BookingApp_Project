
using Dоmain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repos
{
    public interface IUserRepos
    {
        
        Task<IList<User>> GetAllUsers();

        Task Commit();
    }
}
