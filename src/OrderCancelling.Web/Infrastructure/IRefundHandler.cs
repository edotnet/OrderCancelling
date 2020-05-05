using OrderCancelling.Web.Models;
using System.Threading.Tasks;

namespace OrderCancelling.Web.Infrastructure
{
    public interface IRefundHandler
    {
        Task<RefundResult> Refund(RefundArgs args); 
    }
}
