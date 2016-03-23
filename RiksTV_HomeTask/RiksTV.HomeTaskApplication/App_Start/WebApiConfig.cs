using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RiksTV.HomeTaskApplication
{
    using System.Net.Http.Formatting;

    using Newtonsoft.Json.Serialization;

    using RiksTV.HomeTaskApplication.Controllers;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //Going camel case in Web API http://frankapi.wordpress.com/2012/09/09/going-camelcase-in-asp-net-mvc-web-api/
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{*url}",
                defaults: new { controller = "ApiEmpty" }
            );

            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
        }
    }
}
