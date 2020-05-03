using OrderCancelling.Web.Infrastructure.Enums;

namespace OrderCancelling.Web.Models
{
    public class Order
    {
        public string Id { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}