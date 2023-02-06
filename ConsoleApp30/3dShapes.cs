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
     
        public _3dShapes(double a, double b)
        {
            this.a = a;
            this.b = b; 
           
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
