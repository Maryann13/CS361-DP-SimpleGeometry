using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GeometryLib.Shapes
{
    public class Square : Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            Debug.Assert(side > 0, "side > 0");
            Side = side;
        }

        public override string Print()
        {
            return $"Square: side = {Side}, area = {Area()}";
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
