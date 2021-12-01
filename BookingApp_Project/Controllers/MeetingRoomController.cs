using Application.Behaviour.Room.Command.AddMeeting;
using Application.Behaviour.Room.Query.GetMeeting;
using Dоmain.Models;
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
    [Route("BookingApp_Project/meeting-room")]
    [ApiController]
    public class MeetingRoomController : ControllerBase
    {
    private readonly IMediator _mediator;

    public MeetingRoomController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("get-meetings")]
    public async Task<IActionResult> GetAllMeetings([FromQuery] DateTime date)
    {
        var meetings = await _mediator.Send(new GetMeetingQuery(date.Date));
        return Ok(meetings);
    }

    [HttpPost("meetings/create-meeting")]
    public async Task<IActionResult> ReserveMeeting([FromBody] MeetingRequest request)
    {
        var meet = new MeetingRoom 
        {
            MeetingTime = request.Date,
            Duration = new TimeSpan(0, request.Duration, 0),
            MeetingTheme = request.MeetingObject,
        };

        await _mediator.Send(new AddMeetingCommand(meet));
        return NoContent();
    }
    }

}
