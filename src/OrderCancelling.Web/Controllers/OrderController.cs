using OrderCancelling.Web.Infrastructure.Enums;
using OrderCancelling.Web.Models;
using OrderCancelling.Web.Templates.Orders;
using System;
using System.Web.Mvc;

namespace OrderCancelling.Web.Controllers
{
    public class OrderController : Controller
    {
        private Order order { get; } = new Order
        {
            Id = "A0003256523",
            Status = OrderStatus.PendingPayment,
            PaymentMethod = PaymentMethod.BankTransfer
        };

        public ActionResult Index()
        {
            var html = IndexTemplate.Render(order);

            return Content(html);
        }

        public ActionResult CancelOrderAction()
        {
            var orderId = HttpContext.Request.QueryString.GetValues("orderId")[0];

            var html = CancelOrderTemplate.Render(orderId, order);

            return Content(html);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public bool CancelOrder(string orderId)
        {
            var rnd = new Random();
            return 50 <= rnd.Next(100);
        }
    }
}