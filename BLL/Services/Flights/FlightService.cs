using AutoMapper;
using BLL.DTO.Flights;
using BLL.Services.GenericService;
using BLL.Wrapping.Exceptions;
using DAL.Models;
using DAL.Repositories.Flights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Flights
{
    public class FlightService : GenericService<Flight, FlightDto>, IFlightService
    {
        public readonly IFlightRepository _FlightRepository;
        public readonly IMapper _mapper;

        public FlightService(IFlightRepository flightRepository, IMapper mapper) : base(flightRepository, mapper)
        {
            _FlightRepository = flightRepository;
            _mapper = mapper;
        }

        

    }
}
