using Dоmain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Requests
{
    public class BookingRequest
    {
        public Guid UserId { get; set; }
        public BookingType Type { get; set; }
        public DateTime Date { get; set; }
        
        public int? Day { get; set; }
    }
}
