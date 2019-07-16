using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Services
{
    public class SmsService
    {
        public void SendSms(string mobilePhone)
        {
            Console.WriteLine($"Sending an email to {mobilePhone}.");
        }
    }
}
