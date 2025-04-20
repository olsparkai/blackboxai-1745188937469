using System.Threading.Tasks;
using PaymentHelper.Interfaces;

namespace PaymentHelper.Gateways
{
    public class HyperpayGateway : IPaymentGateway
    {
        public async Task<string> InitializePaymentAsync(decimal amount, string currency, string description)
        {
            // TODO: Implement Hyperpay payment initialization logic here
            await Task.Delay(100); // Simulate async work
            return "HyperpayPaymentId123";
        }

        public async Task<bool> VerifyPaymentAsync(string paymentId)
        {
            // TODO: Implement Hyperpay payment verification logic here
            await Task.Delay(100); // Simulate async work
            return true;
        }

        public async Task<string> GetPaymentStatusAsync(string paymentId)
        {
            // TODO: Implement Hyperpay payment status retrieval logic here
            await Task.Delay(100); // Simulate async work
            return "Completed";
        }
    }
}
