using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.Facades;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client need to buy a milk tea by cash and freeshipping.");

            ShopFacade.GetInstanceShopFacade().BuyMilkTeaByCashWithFreeShipping("trungct@gmail.com");

            // You can practice with a attached image (additional_facade_patterns.png) in order to get more knowledge.
        }
    }
}
