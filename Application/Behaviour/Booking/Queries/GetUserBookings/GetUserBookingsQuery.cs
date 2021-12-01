using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Behaviour.Booking.Queries.GetUserBookings
{
    public class GetUserBookingsQuery : IRequest<IList<BookingQueryRepsonse>>
    {
        public GetUserBookingsQuery(Guid userId)
        {
            UserId = userId;
        }

        public Guid UserId { get; private set; }
    }
}
