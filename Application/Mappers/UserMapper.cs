using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dоmain.Models;
using Dоmain.DTOs;
using Microsoft.Extensions.DependencyInjection;


namespace Application.Mappers
{
    public static class UserMapper 
    {
        public static UserDTO MappingDTO(User source)
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<User, UserDTO>()
                .ForMember(nameof(UserDTO.WorkingPlaceBookings),       
                    src => src.MapFrom(user => user.WorkingPlaceBookings.Select(item => new WorkingPlaceBookingDTO {
                        Date = item.Date,
                        Id = item.Id,
                        Status = item.Status,
                        Type = item.Type,
                    }))));
            


            IMapper map = config.CreateMapper();
            return map.Map<User, UserDTO>(source);
        }
        public static User MappingModel(UserDTO source)
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<UserDTO, User>()
                .ForMember(nameof(User.WorkingPlaceBookings),
                    src => src.MapFrom(user => user.WorkingPlaceBookings.Select(item => new WorkingPlaceBooking {
                        Date = item.Date,
                        Id = item.Id,
                        Status = item.Status,
                        Type = item.Type,
                    }))));



            IMapper map = config.CreateMapper();
            return map.Map<UserDTO, User>(source);
        }
    }
}


