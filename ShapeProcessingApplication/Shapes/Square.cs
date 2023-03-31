using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Shapes
{
    public class Square : IShape
    {
        private double side;
        private double? area;
        public Square(double side)
        {
            this.side = side;
        }
        public double? Area => area == null ? CalculateArea() : area;

        public double? CalculateArea()
        {
            area = Math.Pow(side, 2);
            return area;
        }

        override
        public string ToString()
        {
            return string.Format("{0} {1}", Shape.Square, area);
        }
    }
}
