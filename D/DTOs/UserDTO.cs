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
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string AvatarUrl { get; set; }

        public RoleOfUser Role { get; set; }
        
        //  EntityFramework
        public ICollection<WorkingPlaceBookingDTO> WorkingPlaceBookings { get; set; }
    }
}
