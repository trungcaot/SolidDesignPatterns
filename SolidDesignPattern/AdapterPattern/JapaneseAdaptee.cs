using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class JapaneseAdaptee
    {
        public void Receive(string words)
        {
            Console.WriteLine("Received message from VN's clients.");
            Console.WriteLine(words);
        }
    }
}
