using ShapeProcessingApplication.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Services
{
    public class ShapeProcessor : IShapeProcessor
    {
        private IList<IShape> shapeList;

        public ShapeProcessor()
        {
            shapeList = new List<IShape>();
        }

        public void Add(IShape newShape)
        {
            shapeList.Add(newShape);
        }

        public void Clear()
        {
            shapeList.Clear();
        }

        public void Sort()
        {
            shapeList = shapeList.OrderByDescending(shape => shape.Area).ToList();
        }

        public IEnumerable<IShape> getList()
        {
            return shapeList;
        }
    }
}
