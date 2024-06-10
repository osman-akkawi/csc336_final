using AutoMapper;
using BLL.DTO.Airplanes;
using BLL.DTO.Flights;
using BLL.DTO.Passengers;
using BLL.DTO.Pilots;
using BLL.DTO.Revservations;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Airplane, AirplaneDto>().ReverseMap();
            CreateMap<Flight, FlightDto>().ReverseMap();
            CreateMap<Passenger, PassengerDto>().ReverseMap();
            CreateMap<Pilot, PilotDto>().ReverseMap();
            CreateMap<Reservation, ReservationDto>().ReverseMap();

        }

    }
}
