using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Mappers;
using Application.Repos;
using MediatR;

namespace Application.Behaviour.Booking.Queries.GetAllBookings
{
    public class GetAllBookingsQueryHandler : IRequestHandler<GetAllBookingsQuery, IList<BookingQueryRepsonse>>
    {
        private readonly IWorkingPlaceBookingRepos _repos;
        public GetAllBookingsQueryHandler(IWorkingPlaceBookingRepos repos)
        {
            _repos = repos;
        }

        public async Task<IList<BookingQueryRepsonse>> Handle(GetAllBookingsQuery request, CancellationToken cancellationToken)
        {
            var place_bookings = await _repos.GetWorkingPlacesBookings(request.Date);
            return place_bookings.Select(a => new BookingQueryRepsonse(WorkingPlaceBookingMapper.MappingDTO(a))).ToList();
        }
    }
}
