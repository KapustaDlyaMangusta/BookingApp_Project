using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dоmain.DTOs
{
    public class WorkingPlaceDTO
    {
        public long Id { get; set; }
        public int NumPlace { get; set; }

        //  EntityFramework
        public ICollection<WorkingPlaceBookingDTO> WorkingPlaceBookings { get; set; }
    }
}
