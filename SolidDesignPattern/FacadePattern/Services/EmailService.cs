using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Services
{
    public class EmailService
    {
        public void SendEmail(string emailTo)
        {
            Console.WriteLine($"Sending an email to {emailTo}.");
        }
    }
}
