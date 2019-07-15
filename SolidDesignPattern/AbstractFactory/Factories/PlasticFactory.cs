using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PlasticFactory : FuritureAbstractFactory
    {
        public IChair CreateChair()
        {
            return new PlasticChair();
        }

        public ITable CreateTable()
        {
            return new PlasticTable();
        }
    }
}
