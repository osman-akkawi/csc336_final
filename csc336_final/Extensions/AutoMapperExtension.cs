﻿using BLL.Mapping;

namespace csc336_final.Extensions
{
    public static class AutoMapperExtension
    {

        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection service)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));

            return service;

        }


    }
}
