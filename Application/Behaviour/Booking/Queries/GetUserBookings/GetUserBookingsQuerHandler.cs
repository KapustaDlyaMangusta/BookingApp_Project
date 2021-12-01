using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Mappers;
using Application.Repos;
using MediatR;

namespace Application.Behaviour.Booking.Queries.GetUserBookings
{
    public class GetUserBookingsQuerHandler : IRequestHandler<GetUserBookingsQuery, IList<BookingQueryRepsonse>>
    {
        private readonly IWorkingPlaceBookingRepos _repos;

        public GetUserBookingsQuerHandler( IWorkingPlaceBookingRepos repos)
        {
            _repos = repos;
        }

        public async Task<IList<BookingQueryRepsonse>> Handle(GetUserBookingsQuery request, CancellationToken cancellationToken)
        {
            var userBookings = await _repos.GetWorkingPlacesBookingsByUser(request.UserId);
            return userBookings.Select(x => new BookingQueryRepsonse(WorkingPlaceBookingMapper.MappingDTO(x))).ToList();
        }
    }
}
