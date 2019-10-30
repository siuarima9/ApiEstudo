using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Service.WebApi.ProvaDev.Configuration
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();
        }
    }
}