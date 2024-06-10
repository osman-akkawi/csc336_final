using DAL.Models;
using DAL.Repositories._GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Airplanes
{
    using Entity = Airplane;

    public class AirplaneRepository : GenericRepository<Airplane>, IAirplaneRepository
    {
        public AirplaneRepository(AirplaneSystemContext AirplaneSystemContext) : base(AirplaneSystemContext)
        {

        }
    

    
    }
}
