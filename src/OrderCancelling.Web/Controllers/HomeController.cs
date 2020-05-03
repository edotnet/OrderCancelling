using OrderCancelling.Resources;
using OrderCancelling.Web.Infrastructure.Enums;
using OrderCancelling.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderCancelling.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var order = new Order
            {
                Id = "A0003256523",
                Status = OrderStatus.PendingPayment,
                PaymentMethod = PaymentMethod.Paypal
            };

            return View(order);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}