namespace OrderCancelling.Web.Models.RefundArguments
{
    public class PaypalRefundArgs : RefundArgs
    {
        public string PaymentCode { get; set; }
    }
}
