using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Cone : _3dShapes
    {
        public double area;
        /// <summary>
        /// Cone create method
        /// </summary>
        /// <param name="height"></height>
        /// <param name="radius"></radius>
        public Cone(double height, double radius) : base(height, radius)
        {

        }

        public override double Area()
        {
            area = pi * radius * radius;
            return area;
        }

        public override double Volume()
        {
            double volume = Math.Round((area * height / 3), 2);
            return volume;
        }

       
    }
}
