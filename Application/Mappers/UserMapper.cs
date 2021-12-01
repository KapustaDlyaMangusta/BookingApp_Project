
using System.Linq;
using AutoMapper;
using Dоmain.Models;
using Dоmain.DTOs;


namespace Application.Mappers
{
    public static class UserMapper 
    {
        public static UserDTO MappingDTO(User source)
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<User, UserDTO>()
                .ForMember(nameof(UserDTO.WorkingPlaceBookings),       
                    src => src.MapFrom(user => user.WorkingPlaceBookings
                    .Select(item => new WorkingPlaceBookingDTO {
                        BookingDay = item.BookingDay,
                        Date = item.Date,
                        Id = item.Id,
                        Status = item.Status,
                        Type = item.Type,
                    }))));
            


            IMapper map = config.CreateMapper();
            return map.Map<User, UserDTO>(source);
        }
    }
}


