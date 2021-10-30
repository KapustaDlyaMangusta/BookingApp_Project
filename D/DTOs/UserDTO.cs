using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dоmain.Enums;
using Microsoft.Extensions.DependencyInjection;


namespace Dоmain.DTOs
{
    public class UserDTO
    {
        public long Id { get; set; }

        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }

        public string UserAvatarUrl { get; set; }

        public RoleOfUser Role { get; set; }
        
        //  EntityFramework
        public ICollection<WorkingPlaceBookingDTO> WorkingPlaceBookings { get; set; }
    }
}
