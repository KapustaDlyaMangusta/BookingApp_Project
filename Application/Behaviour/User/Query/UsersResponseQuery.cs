using Dоmain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Behaviour.User.Query
{
    public class UsersResponseQuery
    {
        public UsersResponseQuery(UserDTO user)
        {
            User = user;
        }

        public UserDTO User { get; set; }
    }
}
