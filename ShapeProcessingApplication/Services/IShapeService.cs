using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Services
{
    public interface IShapeService
    {
        bool IsPathExists(string filePath);
        string[] ReadFile(string filePath);
        bool ProcessFile(string[] lines);
        void Write();
    }
}
