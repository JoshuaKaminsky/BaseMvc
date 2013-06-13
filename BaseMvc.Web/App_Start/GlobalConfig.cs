using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace BaseMvc.Web
{
    public class GlobalConfig
    {
        public static void CustomizeConfig(HttpConfiguration config)
        {
            config.Filters.Add(new ValidationActionFilter());

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new StringEnumConverter());
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}