using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FuritureAbstractFactory factory = FurnitureFactory.GetFactory(MaterialType.Plastic);

            IChair chair = factory.CreateChair();
            chair.Create(); // create a plastic chair

            ITable table = factory.CreateTable();
            table.Create(); // create a plastic table
        }
    }
}
