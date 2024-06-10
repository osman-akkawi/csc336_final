using csc336_final.Filters;

namespace csc336_final.Extensions
{
    public static class AddControllers
    {

        public static IServiceCollection AddController(this IServiceCollection Services)
        {
            Services.AddControllers(options =>
            {
                options.Filters.Add(new GlobalExceptionFilter());
            });
            return Services;
        }
    }
}
