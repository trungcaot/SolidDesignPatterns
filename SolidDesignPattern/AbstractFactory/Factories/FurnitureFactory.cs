using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public enum MaterialType
    {
        Plastic = 0,
        Wood = 1
    }

    public static class FurnitureFactory
    {
        public static FuritureAbstractFactory GetFactory(MaterialType materialType)
        {
            switch(materialType)
            {
                case MaterialType.Plastic:
                    return new PlasticFactory();
                case MaterialType.Wood:
                    return new WoodFactory();
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
