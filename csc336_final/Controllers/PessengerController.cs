using Microsoft.AspNetCore.Mvc;

namespace csc336_final.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PessengerController : GenericController<PessengerDto>
    {
        private readonly IPessengerService _pessengerService;
        public PessengerController(IPessengerService service) : base(service)
        {
            _pessengerService = service;
        }



    }
}