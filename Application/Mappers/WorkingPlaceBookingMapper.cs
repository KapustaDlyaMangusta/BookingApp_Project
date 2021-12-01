using AutoMapper;
using Domain.Models;
using Dоmain.DTOs;
using Dоmain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class WorkingPlaceBookingMapper
    {
        public static WorkingPlaceBookingDTO MappingDTO(WorkingPlaceBooking source)
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<WorkingPlaceBooking, WorkingPlaceBookingDTO>()
                .ForMember(nameof(WorkingPlaceBookingDTO.User),
                    src => src.MapFrom(item => new UserDTO {
                        Id = item.User.Id,
                        UserName = item.User.UserName,
                        AvatarUrl = item.User.AvatarUrl,
                        Role = item.User.Role,
                    }))
                .ForMember(nameof(WorkingPlaceBookingDTO.WorkingPlace),
                    src => src.MapFrom(item => new WorkingPlaceDTO {
                        Id = item.WorkingPlace.Id,
                        NumPlace = item.WorkingPlace.NumPlace,
                    })));


            IMapper map = config.CreateMapper();
            return map.Map<WorkingPlaceBooking, WorkingPlaceBookingDTO>(source);
        }
    }
}
