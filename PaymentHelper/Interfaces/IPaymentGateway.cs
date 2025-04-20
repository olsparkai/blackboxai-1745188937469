using System.Threading.Tasks;

namespace PaymentHelper.Interfaces
{
    public interface IPaymentGateway
    {
        Task<string> InitializePaymentAsync(decimal amount, string currency, string description);
        Task<bool> VerifyPaymentAsync(string paymentId);
        Task<string> GetPaymentStatusAsync(string paymentId);
    }
}
