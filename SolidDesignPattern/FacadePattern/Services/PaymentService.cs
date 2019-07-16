using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Services
{
    public class PaymentService
    {
        public void PaymentByPaypal()
        {
            Console.WriteLine("Payment by Paypal.");
        }

        public void PaymentByCreditCard()
        {
            Console.WriteLine("Payment by Credit card.");
        }

        public void PaymentByCash()
        {
            Console.WriteLine("Payment by cash.");
        }

        public void PaymentByMomo()
        {
            Console.WriteLine("Payment by Momo E-wallet.");
        }
    }
}
