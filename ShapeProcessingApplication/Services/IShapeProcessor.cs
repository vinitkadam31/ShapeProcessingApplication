using ShapeProcessingApplication.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Services
{
    public interface IShapeProcessor
    {
        void Add(IShape newShape);
        void Clear();
        void Sort();
        IEnumerable<IShape> getList();
    }
}
