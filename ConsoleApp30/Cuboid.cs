using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Cuboid : _3dShapes
    {
        /// <summary>
        /// Cuboid create method
        /// </summary>
        /// <param name="a"></a side>
        /// <param name="b"></b side>
        /// <param name="c"></c side>
        public Cuboid(double a, double b, double c) : base(a, b, c)
        {

        }

        public override double Area()
        {
            double area=2*(a*b+a*c+b*c);
            return area;
        }

        public override double Volume()
        {
            double volume=a*b*c;
            return volume;
        }

        
    }
}
