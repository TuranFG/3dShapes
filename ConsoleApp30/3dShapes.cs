using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public abstract class _3dShapes
    {

        public const double pi = 3.14;
        
        protected double a;
        protected double b;
        protected double c;
        protected double height;
        protected double radius;
        public _3dShapes(double a, double b, double c)
        {
            this.a = a;
            this.b = b; 
            this.c = c; 
        }

        public _3dShapes(double height, double radius)
        {
            this.height = height;
            this.radius = radius;

        }


        public abstract double Area();

        public abstract double Volume();

        public override string ToString()
        {
            return @$"<<{this.GetType().Name}>>
                         Area :{this.Area()}
                         Volume :{this.Volume()}";
        }

    }
}
