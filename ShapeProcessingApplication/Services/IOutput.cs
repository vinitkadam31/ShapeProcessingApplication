using ShapeProcessingApplication.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Services
{
    public interface IOutput
    {
        void write(IEnumerable<IShape> shapeList);
    }
}
