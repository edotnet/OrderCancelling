using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace OrderCancelling.Web.Templates
{
    public class TemplateGlobalCss
    {
        public static IEnumerable<IHtmlString> Apply()
        {
            yield return Styles.Render("~/Content/css");
        }
    }
}