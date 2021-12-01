using Application.Repos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Behaviour.Booking.Queries.GetAllBookings
{
    public class GetAllBookingsQuery :  IRequest<IList<BookingQueryRepsonse>>
    {
        public GetAllBookingsQuery(DateTime date)
        {
            Date = date;
        }

        public DateTime Date { get; private set; }
    }
}
