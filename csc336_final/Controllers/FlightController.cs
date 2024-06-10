using BLL.DTO.Flights;
using BLL.Services.Flights;
using BLL.Wrapping.Exceptions;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace csc336_final.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class FlightController : GenericController<FlightDto>
    {
        private readonly IFlightService _flightService;
        public FlightController(IFlightService service) : base(service)
        {
            _flightService = service;
        }

        

    }
}
