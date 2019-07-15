using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adapter Pattern.");
            //--------------------------------------------//
            JapaneseAdaptee adaptee = new JapaneseAdaptee();
            IVietnameseTarget vietnameseTarget = new TranslatorAdapter(adaptee);

            vietnameseTarget.Send("Xin Chào!");
        }
    }
}
