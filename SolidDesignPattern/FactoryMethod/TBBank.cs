using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TBBank : IBank
    {
        public string GetBankName()
        {
            return "TBBank";
        }
    }
}
