using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WoodTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("Create a wood chair.");
        }
    }
}
