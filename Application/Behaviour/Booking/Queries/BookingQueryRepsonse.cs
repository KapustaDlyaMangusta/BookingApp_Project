using Dоmain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Behaviour.Booking.Queries
{
    public class BookingQueryRepsonse
    {

        public BookingQueryRepsonse(WorkingPlaceBookingDTO place_booking)
        {
            PlaceBooking = place_booking;
        }
        public WorkingPlaceBookingDTO PlaceBooking { get; private set; }
    }
}
