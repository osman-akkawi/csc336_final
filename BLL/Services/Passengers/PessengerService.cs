using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Passengers
{
    public class PessengerService  GenericService<PessengerService, <PessengerDto>, IPessengerService
    {
        public readonly IPessengerRepository _PessengerRepository;
    public readonly IMapper _mapper;

    public PessengerService(IPessengerRepository pessengerRepository, IMapper mapper) : base(pessengerRepository, mapper)
    {
        _PessengerRepository = pessengerRepository;
        _mapper = mapper;
    }



}
}

    {
}
}
