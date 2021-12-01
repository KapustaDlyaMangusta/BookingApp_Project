using Application.Repos;
using Dоmain.Enums;
using Dоmain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Behaviour.Booking.Command.BookPlace
{
    public class BookPlaceCommandHandler : IRequestHandler<BookPlaceCommand>
    {
        private IWorkingPlaceBookingRepos _booking_repos;
        private IWorkingPlaceRepos _place_repos;

        public BookPlaceCommandHandler(IWorkingPlaceBookingRepos bookingRepos, IWorkingPlaceRepos placeRepos)
        {
            _booking_repos = bookingRepos;
            _place_repos = placeRepos;
        }

        public async Task<Unit> Handle(BookPlaceCommand request, CancellationToken cancellationToken)
        {
            for (int i = 0; i < (request.Day.HasValue ? request.Day : 1); i++)
            {
                var working_place_booking = new WorkingPlaceBooking {
                    Date = request.BookingType == BookingType.ConstantBooking ? null
                        : new DateTime(request.Date.Year, request.Date.Month, request.Date.Day + i),

                    Type = request.BookingType,
                    Status = request.Day > 1 ? BookingStatuses.Pending : BookingStatuses.Approved,
                    UserId = request.UserId,
                    WorkingPlaceId = request.PlaceId,
                    BookingDay = (int)request.Day,
                };

                await _booking_repos.AddWorkingPlaceBooking(working_place_booking);
            }

            await _booking_repos.Commit();
            return Unit.Value;
        }
    }

}
