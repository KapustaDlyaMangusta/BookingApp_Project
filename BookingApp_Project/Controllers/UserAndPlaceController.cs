using Application.Behaviour.User.Query.GetUsers;
using Application.Behaviour.WorkingPlace.Queries.GetAllWorkingPlaces;
using Application.Behaviour.WorkingPlace.Queries.GetWorkingPlaceByPlaceNumber;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [Route("BookingApp_Project/user-and-place")]
    [ApiController]
    public class UserAndPlaceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserAndPlaceController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("get-users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _mediator.Send(new GetUsersQuery());
            return Ok(users);
        }

        [HttpGet("get-working-places")]
        public async Task<IActionResult> GetAll()
        {
            var places = await _mediator.Send(new GetAllWorkingPlacesQuery());
            return Ok(places);
        }

        [HttpGet("get-working-places/{numPlace}/working-place")]
        public async Task<IActionResult> FindWorkPlaceByPlaceNumber(
           [FromRoute] int numPlace)

        {
            var workPlace = await _mediator.Send(new GetWorkingPlaceByPlaceNumberQuery(numPlace));
            return Ok(workPlace);
        }
    }
}
