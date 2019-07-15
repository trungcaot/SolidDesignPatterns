using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public enum BankType
    {
        TBBank = 0,
        Vietcombank = 1
    }

    public static class BankFactory
    {
        public static IBank GetBank(BankType bankType)
        {
            switch(bankType)
            {
                case BankType.TBBank:
                    return new TBBank();
                case BankType.Vietcombank:
                    return new Vietcombank();
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
