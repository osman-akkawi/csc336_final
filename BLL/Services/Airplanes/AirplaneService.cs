using AutoMapper;
using BLL.DTO.Airplanes;
using BLL.Services.GenericService;
using BLL.Wrapping.Exceptions;
using DAL.Models;
using DAL.Repositories.Airplanes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Airplanes
{
    public class AirplaneService : GenericService<Airplane, AirplaneDto>, IAirplaneService
    {
        public readonly IAirplaneRepository _AirplaneRepository;
        public readonly IMapper _mapper;
        public AirplaneService(IAirplaneRepository airplaneRepository, IMapper mapper) : base(airplaneRepository, mapper)
        {
            _AirplaneRepository = airplaneRepository;
            _mapper = mapper;
        }
       
    }
}
