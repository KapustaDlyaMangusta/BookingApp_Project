using AutoMapper;
using Dоmain.DTOs;
using Dоmain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class MeetingRoomMapper
    {
        public static MeetingRoomDTO MappingDTO(MeetingRoom source)
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<MeetingRoom, MeetingRoomDTO>()
                .ForMember(nameof(MeetingRoomDTO.MeetingOwner),
                    src => src.MapFrom(item => 
                    new UserDTO {
                        Id = item.Id,
                        UserName = item.MeetingOwner.UserName,
                        AvatarUrl = item.MeetingOwner.AvatarUrl,
                        Role = item.MeetingOwner.Role,
                    }))
                .ForMember(nameof(MeetingRoomDTO.RequiredParticipants),
                    src => src.MapFrom(arr => arr.MeetingRequiredParticipants
                    .Select(item => item.RequiredParticipant)))
                .ForMember(nameof(MeetingRoomDTO.OptionalParticipants),
                    src => src.MapFrom(arr => 
                    arr.MeetingOptionalParticipants
                    .Select(item => item.OptionalParticipant))));



            IMapper map = config.CreateMapper();
            return map.Map<MeetingRoom, MeetingRoomDTO>(source);
        }
    }
}
