using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Shapes
{
    public class Circle : IShape
    {
        private double diameter;
        private double? area;

        public Circle(double diameter)
        {
            this.diameter = diameter;
        }
        public double? Area => area == null ? CalculateArea() : area;

        public double? CalculateArea()
        {
            area = Math.PI * Math.Pow(diameter / 2, 2);
            return area;
        }

        override
        public string ToString()
        {
            return string.Format("{0} {1:0.00}", Shape.Circle, area);
        }
    }
}
