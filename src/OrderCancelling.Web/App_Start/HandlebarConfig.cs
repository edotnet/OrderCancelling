using HandlebarsDotNet;
using OrderCancelling.Web.Templates;
using System;
using System.IO;
using System.Web.Hosting;

namespace OrderCancelling.Web
{
    public class HandlebarConfig
    {
        public static void RegisterHandlebar()
        {
            
            var returnPagePath = HostingEnvironment.MapPath(string.Format(TemplateConstants.HandlebarsPathFormat, "ReturnPagePartial"));
            var returnPageSource = File.ReadAllText(returnPagePath);

            Handlebars.RegisterTemplate("ReturnPage", returnPageSource);
        }
    }
}