using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace csc336_final.Extensions
{
    public static class StartUpExtension
    {

        public static IServiceCollection addDb(this IServiceCollection service, ConfigurationManager config)
        {

            var ConnectionString = config.GetConnectionString("DefaultConnection");

            service.AddDbContext<AirplaneSystemContext>(options =>
                            options.UseSqlServer(ConnectionString)

                            );


            return service;




        }


    }
}