using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Shapes
{
    class Rectangle : IShape
    {
        private double width, height;
        private double? area;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double? Area => area == null ? CalculateArea() : area;

        public double? CalculateArea()
        {
            area = width * height;
            return area;
        }

        override
        public string ToString()
        {
            return string.Format("{0} {1}", Shape.Rectangle, area);
        }
    }
}
