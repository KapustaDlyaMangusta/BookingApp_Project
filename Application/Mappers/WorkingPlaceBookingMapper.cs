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
                        Id = item.Id,
                        UserFirstName = item.User.UserFirstName,
                        UserLastName = item.User.UserLastName,
                        UserAvatarUrl = item.User.UserAvatarUrl,
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
        public static WorkingPlaceBooking MappingModel(WorkingPlaceBookingDTO source)
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<WorkingPlaceBookingDTO, WorkingPlaceBooking>()
                .ForMember(nameof(WorkingPlaceBooking.User),
                    src => src.MapFrom(item => new User {
                        Id = item.Id,
                        UserFirstName = item.User.UserFirstName,
                        UserLastName = item.User.UserLastName,
                        UserAvatarUrl = item.User.UserAvatarUrl,
                        Role = item.User.Role,
                    }))
                .ForMember(nameof(WorkingPlaceBookingDTO.WorkingPlace),
                    src => src.MapFrom(item => new WorkingPlace {
                        Id = item.WorkingPlace.Id,
                        NumPlace = item.WorkingPlace.NumPlace,
                    })));


            IMapper map = config.CreateMapper();
            return map.Map<WorkingPlaceBookingDTO, WorkingPlaceBooking>(source);
        }
    }
}
