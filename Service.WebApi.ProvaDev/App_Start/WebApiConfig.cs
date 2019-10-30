using Application.ProvaDev.AutoMapper;
using AutoMapper;
using Infra.ProvaDev.IoC;
using Service.WebApi.ProvaDev.Configuration;
using System.Web.Http;

namespace Service.WebApi.ProvaDev
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            /*(config.Services as IServiceCollection).AddAutoMapperSetup();*/

            //AutoMapperConfiguration.RegisterMappings().CreateMapper();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

    }
}
