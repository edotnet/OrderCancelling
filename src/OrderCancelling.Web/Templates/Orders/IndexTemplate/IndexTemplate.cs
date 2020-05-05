using HandlebarsDotNet;
using OrderCancelling.Web.Infrastructure.Enums;
using OrderCancelling.Web.Models;
using System.Web.Optimization;

namespace OrderCancelling.Web.Templates.Orders
{
    using OrderCancelling.Resources;
    using System.IO;
    using System.Web.Hosting;

    public class IndexTemplate
    {
        public static string Render(Order model)
        {
            var orderCancelEnabled = model.Status == OrderStatus.PendingPayment || model.Status == OrderStatus.Processing;
            var orderCancelFullEnabled = model.Status == OrderStatus.Delivered;
            var orderSent = model.Status == OrderStatus.Sent;
            var handleBars = Handlebars.Create(new HandlebarsConfiguration { FileSystem = new DiskFileSystem() });
            var template = handleBars.CompileView(HostingEnvironment.MapPath(string.Format(TemplateConstants.HandlebarsPathFormat, "IndexTemplate")));
            var viewModel = new 
            { 
                orderCancelEnabled,
                orderCancelFullEnabled,
                orderSent,
                model.Id,
                model.PaymentMethod,
                model.Status,
                Resources.EditOrder,
                Resources.OrderId,
                Resources.CancelOrder,
                Resources.Full,
                Resources.PartialOrderReturn,
                Resources.ProcessedOrderWarning,
                Resources.ProcessedOrderWarningDescriptor,
            };

            var result = template(viewModel);
            return result;
        }
    }
}