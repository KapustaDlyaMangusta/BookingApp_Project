using System;
using System.Collections.Generic;

namespace Dоmain.DTOs
{
    public class WorkingPlaceDTO
    {
        public Guid Id { get; set; }
        public int NumPlace { get; set; }

        //  EntityFramework
        public ICollection<WorkingPlaceBookingDTO> WorkingPlaceBookings { get; set; }
    }
}
