using BLL.DTO.Airplanes;
using BLL.Services.Airplanes;
using Microsoft.AspNetCore.Mvc;

namespace csc336_final.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AirplaneController : GenericController<AirplaneDto>
    {
        private readonly IAirplaneService _airplaneService;
        public AirplaneController(IAirplaneService service) : base(service)
        {
            _airplaneService = service;
        }



    }
}
