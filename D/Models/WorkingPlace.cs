using Dоmain.Entities;
using Dоmain.Enums;
using Dоmain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Domain.Models
{   
    public class WorkingPlace : BasicEntity

    {   
        public int  NumPlace { get; set; }


        public ICollection<WorkingPlaceBooking> WorkingPlaceBookings { get; set; }
    }
}