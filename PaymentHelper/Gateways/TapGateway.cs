using System.Threading.Tasks;
using PaymentHelper.Interfaces;

namespace PaymentHelper.Gateways
{
    public class TapGateway : IPaymentGateway
    {
        public async Task<string> InitializePaymentAsync(decimal amount, string currency, string description)
        {
            // TODO: Implement Tap payment initialization logic here
            await Task.Delay(100); // Simulate async work
            return "TapPaymentId123";
        }

        public async Task<bool> VerifyPaymentAsync(string paymentId)
        {
            // TODO: Implement Tap payment verification logic here
            await Task.Delay(100); // Simulate async work
            return true;
        }

        public async Task<string> GetPaymentStatusAsync(string paymentId)
        {
            // TODO: Implement Tap payment status retrieval logic here
            await Task.Delay(100); // Simulate async work
            return "Completed";
        }
    }
}
