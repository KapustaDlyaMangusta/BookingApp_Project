using Dоmain.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Behaviour.User.Command.AddUser
{
    
    
    public class AddUserCommand : IRequest
    {
        public AddUserCommand(UserDTO user)
        {
            User = user;
        }

        public UserDTO User { get; set; }
    }
    
}
