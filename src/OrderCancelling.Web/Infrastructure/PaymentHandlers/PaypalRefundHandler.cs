using OrderCancelling.Web.Models;
using OrderCancelling.Web.Models.RefundArguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCancelling.Web.Infrastructure.PaymentHandlers
{
    public class PaypalRefundHandler : IRefundHandler
    {
        public Task<RefundResult> Refund(RefundArgs args)
        {
            var arguments = args as PaypalRefundArgs;
            return null;
        }
    }
}
