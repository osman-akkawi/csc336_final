using BLL.Services;
using BLL.Services.Flights;
using DAL.Repositories.Airplanes;
using DAL.Repositories.Flights;
using DAL.Repositories.Passengers;

namespace csc336_final.Extensions
{
    public static class repositoryExtension
    {

        public static IServiceCollection AddRepositories(this IServiceCollection Services)
        {

            Services.AddScoped<IAirplaneRepository, AirplaneRepository>();
            Services.AddScoped<IFlightRepository, FlightRepository>();
            Services.AddScoped<IPessengerRepoistory, PassengerRepository>();
            return Services;
        }



    }
}
