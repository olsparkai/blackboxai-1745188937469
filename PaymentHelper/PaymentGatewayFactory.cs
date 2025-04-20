using System;
using PaymentHelper.Interfaces;

namespace PaymentHelper
{
    public static class PaymentGatewayFactory
    {
        public static IPaymentGateway GetPaymentGateway(string gatewayName)
        {
            switch (gatewayName.ToLower())
            {
                case "paypal":
                    return new Gateways.PayPalGateway();
                case "paymob":
                    return new Gateways.PaymobGateway();
                case "fawry":
                    return new Gateways.FawryGateway();
                case "thawani":
                    return new Gateways.ThawaniGateway();
                case "weaccept":
                    return new Gateways.WeAcceptGateway();
                case "kashier":
                    return new Gateways.KashierGateway();
                case "hyperpay":
                    return new Gateways.HyperpayGateway();
                case "tap":
                    return new Gateways.TapGateway();
                case "opay":
                    return new Gateways.OpayGateway();
                case "paytabs":
                    return new Gateways.PaytabsGateway();
                case "vodafonecash":
                case "vodafone cash":
                    return new Gateways.VodafoneCashGateway();
                case "orangemoney":
                case "orange money":
                    return new Gateways.OrangeMoneyGateway();
                case "mezawallet":
                case "meza wallet":
                    return new Gateways.MezaWalletGateway();
                case "etisalatcash":
                case "etisalat cash":
                    return new Gateways.EtisalatCashGateway();
                default:
                    throw new ArgumentException($"Payment gateway '{gatewayName}' is not supported.");
            }
        }
    }
}
