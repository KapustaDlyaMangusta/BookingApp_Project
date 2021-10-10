using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp_Project.Controllers
{
    [ApiController]
    [Route("app/user")]
    public class AppUserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<AppUserController> _logger;

        public AppUserController(ILogger<AppUserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<AppUserController> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new AppUserController
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
