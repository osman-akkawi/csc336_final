using BLL.Services.Airplanes;
using BLL.Services.Flights;
using BLL.Services.Passengers;
using DAL.Repositories.Flights;

namespace csc336_final.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServiceExtension(this IServiceCollection services)
        {
            services.AddScoped<IFlightService, FlightService>();
            services.AddScoped<IAirplaneService, AirplaneService>();
            services.AddScoped<IPessengerSerivce, PessengerService>();


            return services;
        }
    }
}