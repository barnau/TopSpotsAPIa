using Newtonsoft.Json.Serialization;

using System.Web.Http;
using System.Web.Http.Cors;

namespace TopSpotsAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //enable CORS
            var policy = new EnableCorsAttribute("*", "*", "*");

            
            config.EnableCors(policy);

            // Set up a contract resolver to change Normal case to camel to be handled by java
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();


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
