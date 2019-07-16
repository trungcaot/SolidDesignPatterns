using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Services;

namespace FacadePattern.Facades
{
    public class ShopFacade
    {
        private static ShopFacade _shopFacade;

        // services
        private AccountService accountService;
        private PaymentService paymentService;
        private ShippingService shippingService;
        private EmailService emailService;
        private SmsService smsService;

        public ShopFacade()
        {
            accountService = new AccountService();
            paymentService = new PaymentService();
            shippingService = new ShippingService();
            emailService = new EmailService();
            smsService = new SmsService();
        }

        public static ShopFacade GetInstanceShopFacade()
        {
            if (_shopFacade == null)
            {
                _shopFacade = new ShopFacade();
            }
            return _shopFacade;
        }

        public void BuyMilkTeaByCashWithFreeShipping(string email)
        {
            accountService.GetAccount(email);
            paymentService.PaymentByCash();
            shippingService.FreeShipping();
            emailService.SendEmail(email);

            Console.WriteLine("-- Done --");
        }
        
    }
}
