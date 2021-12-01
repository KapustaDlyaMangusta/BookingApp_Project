using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Mappers;
using Application.Repos;
using MediatR;

namespace Application.Behaviour.Booking.Queries.GetWorkingPlaceBooking
{
    /*public class GetWorkingPlaceBookingQueryHandler : IRequestHandler<GetWorkingPlaceBookingQuery, IList<BookingQueryRepsonse>>
    {
        private readonly IWorkingPlaceRepos _reposWorkingPlace;
        private readonly IWorkingPlaceBookingRepos _reposBooking;

        public GetWorkingPlaceBookingQueryHandler(IWorkingPlaceRepos repoWorkingPlace, IWorkingPlaceBookingRepos repoBooking)
        {
            _reposWorkingPlace = repoWorkingPlace;
            _reposBooking = repoBooking;
        }

        public async Task<IList<BookingQueryRepsonse>> Handle (GetWorkingPlaceBookingQuery request, CancellationToken cancellationToken)
        {
            if (request.BookingId == Guid.Empty)
            {
                var res = await _reposWorkingPlace.GetWorkingPlaceById(request.WorkingPlaceId);
                var booking = res.WorkingPlaceBookings.FirstOrDefault(x => x.Date == request.Day && x.User.Id == request.UserId);
                request.BookingId = booking.Id;
            }
            else
            {
                var workingPlaceBookings = await _reposWorkingPlace.GetWorkingPlaceById(request.BookingId);
                return new BookingQueryRepsonse(WorkingPlaceBookingMapper.MappingDTO(workingPlaceBookings))
            }
        }
    }*/
}
