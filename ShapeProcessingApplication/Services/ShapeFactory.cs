using ShapeProcessingApplication.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Services
{
    public class ShapeFactory : IShapeFactory
    {
        public IShape Create(Shape shapeType, string[] splittedLine)
        {
            switch(shapeType)
            {
                case Shape.Circle:
                    return new Circle(double.Parse(splittedLine[1]));
                case Shape.Square:
                    return new Square(double.Parse(splittedLine[1]));
                case Shape.Rectangle:
                    return new Rectangle(double.Parse(splittedLine[1]), double.Parse(splittedLine[2]));
                case Shape.Triangle:
                    return new Triangle(double.Parse(splittedLine[1]), double.Parse(splittedLine[2]));
                default:
                    return null;

            }
        }
    }
}
