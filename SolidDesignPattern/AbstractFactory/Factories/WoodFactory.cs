using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WoodFactory : FuritureAbstractFactory
    {
        public IChair CreateChair()
        {
            return new WoodChair();
        }

        public ITable CreateTable()
        {
            return new WoodTable();
        }
    }
}
