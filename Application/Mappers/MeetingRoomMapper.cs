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
                .ForMember(nameof(MeetingRoomDTO.Booker),
                    src => src.MapFrom(item => new UserDTO {
                        Id = item.Id,
                        UserFirstName = item.Booker.UserFirstName,
                        UserLastName = item.Booker.UserLastName,
                        UserAvatarUrl = item.Booker.UserAvatarUrl,
                        Role = item.Booker.Role,
                    }))
                .ForMember(nameof(MeetingRoomDTO.RequiredParticipants),
                    src => src.MapFrom(arr => arr.MeetingRequiredParticipants
                    .Select(item => new UserDTO {
                        UserAvatarUrl = item.RequiredParticipant.UserAvatarUrl,
                        UserFirstName = item.RequiredParticipant.UserFirstName,
                        Id = item.RequiredParticipant.Id,
                        Role = item.RequiredParticipant.Role,
                    })))
                .ForMember(nameof(MeetingRoomDTO.OptionalParticipants),
                    src => src.MapFrom(arr => arr.MeetingOptionalParticipants
                    .Select(item => new UserDTO {
                        UserAvatarUrl = item.OptionalParticipant.UserAvatarUrl,
                        UserFirstName = item.OptionalParticipant.UserFirstName,
                        Id = item.OptionalParticipant.Id,
                        Role = item.OptionalParticipant.Role,
                    }))));



            IMapper map = config.CreateMapper();
            return map.Map<MeetingRoom, MeetingRoomDTO>(source);
        }
        public static MeetingRoom MappingModel(MeetingRoomDTO source)
        {
            var config = new MapperConfiguration(cfg =>
                cfg.CreateMap<MeetingRoomDTO, MeetingRoom>()

                .ForMember(nameof(MeetingRoom.Booker),
                    src => src.MapFrom(item => new User {
                        Id = item.Id,
                        UserFirstName = item.Booker.UserFirstName,
                        UserLastName = item.Booker.UserLastName,
                        UserAvatarUrl = item.Booker.UserAvatarUrl,
                        Role = item.Booker.Role,
                    })));

            IMapper mapper = config.CreateMapper();
            return mapper.Map<MeetingRoomDTO, MeetingRoom>(source);
        }
    }
}
