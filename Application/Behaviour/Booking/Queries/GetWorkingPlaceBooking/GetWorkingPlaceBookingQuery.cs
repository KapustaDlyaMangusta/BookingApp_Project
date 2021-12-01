using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Behaviour.Booking.Queries.GetWorkingPlaceBooking
{
    public class GetWorkingPlaceBookingQuery : IRequest<BookingQueryRepsonse>
    {
        public GetWorkingPlaceBookingQuery(Guid userId, Guid workingPlaceId, Guid bookingId, DateTime day)
        {
            UserId = userId;
            WorkingPlaceId = workingPlaceId;
            BookingId = bookingId;
            Day = day;
        }

        public Guid UserId { get; private set; }
        public Guid WorkingPlaceId { get; private set; }
        public Guid BookingId { get;  set; }
        public DateTime Day { get; private set; }
    }
}
