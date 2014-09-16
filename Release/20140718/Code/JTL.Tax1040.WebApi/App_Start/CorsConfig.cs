using System;
using WebActivatorEx;
using System.Web.Http;

[assembly: PreApplicationStartMethod(typeof(JTL.Tax1040.WebApi.CorsConfig), "PreStart")]

namespace JTL.Tax1040.WebApi
{
    public static class CorsConfig
    {
        public static void PreStart()
        {
            GlobalConfiguration.Configuration.MessageHandlers.Add(new RedRocket.WebApi.Cors.CorsHandler());
        }
    }
}