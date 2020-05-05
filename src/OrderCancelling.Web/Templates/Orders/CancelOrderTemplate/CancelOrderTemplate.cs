using HandlebarsDotNet;

namespace OrderCancelling.Web.Templates.Orders
{
    using OrderCancelling.Resources;
    using OrderCancelling.Web.Infrastructure.Enums;
    using OrderCancelling.Web.Models;
    using System.IO;
    using System.Web.Hosting;

    public class CancelOrderTemplate
    {
        public static string Render(string orderId, Order order)
        {
            var handleBars = Handlebars.Create(new HandlebarsConfiguration { FileSystem = new DiskFileSystem() });

            var returnPagePath = HostingEnvironment.MapPath(string.Format(TemplateConstants.HandlebarsPathFormat, "ReturnPagePartial"));
            var returnPageSource = File.ReadAllText(returnPagePath);

            handleBars.RegisterTemplate("ReturnPage", returnPageSource);
            var template = handleBars.CompileView(HostingEnvironment.MapPath(string.Format(TemplateConstants.HandlebarsPathFormat, "CancelOrderTemplate")));
            
            var viewModel = new
            {
                orderId,
                order.Id,
                PaymentMethod = (int)order.PaymentMethod,
                Status = (int)order.Status,
                NotBankTrasfer = order.PaymentMethod == PaymentMethod.CreditCard || order.PaymentMethod == PaymentMethod.Paypal,
                //IsPending = order.Status == OrderStatus.PendingPayment,
                IsPending = false,
                Resources.DelayedOrder,
                Resources.ProductsOnOtherShop,
                Resources.Other,
                Resources.MoneyWillBeRefunded,
                Resources.MoneyNotTransfered,
                Resources.TransferNotUpdated,
                Resources.CancelOrder
            };

            var result = template(viewModel);
            return result;
        }
    }
}