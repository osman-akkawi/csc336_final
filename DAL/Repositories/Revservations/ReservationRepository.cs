using DAL.Models;
using DAL.Repositories._GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Revservations
{
    public class ReservationRepository : GenericRepository<Reservation>, IRevservationRepository
    {
        public ReservationRepository(AirplaneSystemContext AirplaneSystemContext) : base(AirplaneSystemContext)
        {

        }
    }
}
