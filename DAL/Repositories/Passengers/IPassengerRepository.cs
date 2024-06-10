using DAL.Models;
using DAL.Repositories._GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Passengers
{
    public interface IPassengerRepository : IGenericRepository<Passenger>
    {
    }
}
