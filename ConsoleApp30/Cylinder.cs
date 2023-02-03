using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Cylinder : Cone
    {
        public Cylinder(double height, double radius) : base(height, radius)
        {
        }

        public override double Area()
        {
            double circleArea=pi*Math.Pow(radius,2);
            double area = 2 * circleArea + 2 * pi * radius * height;
            return area;
        }

        public override double Volume()
        {
            double volume = pi * Math.Pow(radius, 2) * height;
            return volume;
        }
    }
}
