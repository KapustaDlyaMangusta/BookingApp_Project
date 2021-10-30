using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repos;
using Infrastructure.Repos;
using Application.UnitOfWork;

namespace WebUI.Injection
{
    public static class DependencyInjection 
    {
        public static IServiceCollection AddReposConfiguration(this IServiceCollection services)
            => services.AddScoped<IUnitOfWork, UnitOfWork>();


    }
}
