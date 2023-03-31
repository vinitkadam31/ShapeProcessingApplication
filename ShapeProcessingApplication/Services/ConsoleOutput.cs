using ShapeProcessingApplication.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Services
{
    public class ConsoleOutput : IOutput
    {
        public void write(IEnumerable<IShape> shapeList)
        {
            foreach (var shape in shapeList)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}
