using Application.Behaviour.Booking.Command.BookPlace;
using Application.Behaviour.Booking.Queries.GetAllBookings;
using Application.Behaviour.Booking.Queries.GetUserBookings;
using Application.Behaviour.Room.Query.GetMeeting;
using Application.Behaviour.User.Query.GetUsers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Requests;

namespace WebUI.Controllers
{
    [Route("BookingApp_Project/working-place-bookings")]
    [ApiController]
    public class WorkingPlaceBookingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkingPlaceBookingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get-bookings")]
        public async Task<IActionResult> GetBookings([FromQuery] DateTime date)
        {
            var bookings = await _mediator.Send(new GetAllBookingsQuery(date));
            return Ok(bookings);
        }


        [HttpGet("users/{userId}/bookings")]
        public async Task<IActionResult> GetBookingsByUser([FromRoute] Guid userId)
        {
            var bookings = await _mediator.Send(new GetUserBookingsQuery(userId));
            return Ok(bookings);
        }
        [HttpPost("work-places/{placeId}/book")]
        public async Task<IActionResult> Book(
            [FromRoute] Guid placeId,
            [FromBody] BookingRequest request)
        {
            await _mediator.Send(new BookPlaceCommand(
                placeId,
                request.Type,
                request.UserId,

                request.Date,
                request.Day));

            return NoContent();
        }
    }
}
