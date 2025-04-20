using System.Threading.Tasks;
using PaymentHelper.Interfaces;

namespace PaymentHelper.Gateways
{
    public class WeAcceptGateway : IPaymentGateway
    {
        public async Task<string> InitializePaymentAsync(decimal amount, string currency, string description)
        {
            // TODO: Implement WeAccept payment initialization logic here
            await Task.Delay(100); // Simulate async work
            return "WeAcceptPaymentId123";
        }

        public async Task<bool> VerifyPaymentAsync(string paymentId)
        {
            // TODO: Implement WeAccept payment verification logic here
            await Task.Delay(100); // Simulate async work
            return true;
        }

        public async Task<string> GetPaymentStatusAsync(string paymentId)
        {
            // TODO: Implement WeAccept payment status retrieval logic here
            await Task.Delay(100); // Simulate async work
            return "Completed";
        }
    }
}
