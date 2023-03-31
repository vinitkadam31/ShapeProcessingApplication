using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Shapes
{
    public interface IShape
    {
        double? Area { get;}
        double? CalculateArea();
        string ToString();
    }
}
