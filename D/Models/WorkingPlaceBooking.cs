using Domain.Models;
using Dоmain.Entities;
using Dоmain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dоmain.Models
{
    public class WorkingPlaceBooking : BasicEntity
    {  
        public BookingStatuses Status { get; set; }
        public BookingType Type { get; set; }
        public DateTime Date { get; set; }

        //  EntityFramework  
        public long UserId { get; set; }
        public long WorkingPlaceId { get; set; }
        public User User { get; set; }
        public WorkingPlace WorkingPlace { get; set; }
        

    }
}
