namespace OrderCancelling.Web.Models
{
    public class RefundArgs
    {
        private static readonly RefundArgs _args = new RefundArgs();
        public static RefundArgs Empty => _args;
    }
}
