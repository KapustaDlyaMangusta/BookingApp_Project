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
    public static class WorkingPlaceMapper
    {
        public static WorkingPlaceDTO MappingDTO(WorkingPlace source)
        {
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<WorkingPlace, WorkingPlaceDTO>()
                    .ForMember(nameof(WorkingPlaceDTO.WorkingPlaceBookings),
                        src => src.MapFrom(arr => arr.WorkingPlaceBookings.Select(item => new WorkingPlaceBookingDTO {
                            Date = item.Date,
                            Id = item.Id,
                            Status = item.Status,
                            Type = item.Type,
                        }))));



            IMapper map = config.CreateMapper();
            return map.Map<WorkingPlace, WorkingPlaceDTO>(source);
        }
        public static WorkingPlace MappingModel(WorkingPlaceDTO source)
        {
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<WorkingPlaceDTO, WorkingPlace>()
                    .ForMember(nameof(WorkingPlace.WorkingPlaceBookings),
                        src => src.MapFrom(arr => arr.WorkingPlaceBookings.Select(item => new WorkingPlaceBooking {
                            Date = item.Date,
                            Id = item.Id,
                            Status = item.Status,
                            Type = item.Type,
                        }))));



            IMapper map = config.CreateMapper();
            return map.Map<WorkingPlaceDTO, WorkingPlace>(source);
        }
    }
}
