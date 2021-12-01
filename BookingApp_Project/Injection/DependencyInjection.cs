using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repos;
using Infrastructure.Repos;
using Dоmain.Models;
using Domain.Models;

namespace WebUI.Injection
{
    public static class DependencyInjection 
    {
        public static IServiceCollection AddReposConfiguration(this IServiceCollection services)
            => services.AddScoped<IUserRepos, UserRepos>()
                .AddScoped<IWorkingPlaceRepos, WorkingPlaceRepos>()
                .AddScoped<IWorkingPlaceBookingRepos, WorkingPlaceBookingRepos>()
                .AddScoped<IMeetingRoomRepos, MeetingRoomRepos>();
    }
}
