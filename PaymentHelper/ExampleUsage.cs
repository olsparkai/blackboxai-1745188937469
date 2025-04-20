using System;
using System.Threading.Tasks;
using PaymentHelper;

namespace PaymentHelperExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var gateway = PaymentGatewayFactory.GetPaymentGateway("PayPal");

                string paymentId = await gateway.InitializePaymentAsync(100.00m, "USD", "Test payment");
                Console.WriteLine($"Payment initialized with ID: {paymentId}");

                bool isVerified = await gateway.VerifyPaymentAsync(paymentId);
                Console.WriteLine($"Payment verification status: {isVerified}");

                string status = await gateway.GetPaymentStatusAsync(paymentId);
                Console.WriteLine($"Payment status: {status}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
