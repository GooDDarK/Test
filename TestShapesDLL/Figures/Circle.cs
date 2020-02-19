using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapesDLL
{
    public class Circle : Figure
    {
        double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override string Area()
        {
            return (Math.PI * Math.Pow(Radius, 2)).ToString();
        }
        public override string ShapeName()
        {
            return "круг";
        }
    }
}
