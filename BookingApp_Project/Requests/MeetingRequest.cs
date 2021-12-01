using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Requests
{
    public class MeetingRequest
    {
        public DateTime Date { get; set; }
        public int Duration{ get; set; }
        public string MeetingObject{ get; set; }
    }
}
