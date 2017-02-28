using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Debug.Assert(radius > 0, "radius > 0");
            Radius = radius;
        }

        public override string Print()
        {
            return $"Circle: radius = {Radius}, area = {Area()}";
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
