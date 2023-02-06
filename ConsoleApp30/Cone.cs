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
   /// 
   /// </summary>
   /// <param name="height"></a>
   /// <param name="radius"></b>
        public Cone(double height, double radius) : base(height, radius)
        {

        }

        public override double Area()
        {
            area = pi * b * b;
            return area;
        }

        public override double Volume()
        {
            double volume = Math.Round((area * a / 3), 2);
            return volume;
        }

       
    }
}
