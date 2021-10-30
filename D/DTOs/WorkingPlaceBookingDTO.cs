using Dоmain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dоmain.DTOs
{
    public class WorkingPlaceBookingDTO
    {
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public BookingType Type { get; set; }

        public BookingStatuses Status { get; set; }

        //  EntityFramework
        public UserDTO User { get; set; }

        public WorkingPlaceDTO WorkingPlace { get; set; }
    }
}
