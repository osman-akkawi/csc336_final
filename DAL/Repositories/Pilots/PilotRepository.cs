using DAL.Models;
using DAL.Repositories._GenericRepository;
using DAL.Repositories.Flights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Pilots
{
    public class PilotRepository : GenericRepository<Pilot>, IPilotRepository
    {
        public PilotRepository(AirplaneSystemContext AirplaneSystemContext) : base(AirplaneSystemContext)
        {

        }
    }
}
