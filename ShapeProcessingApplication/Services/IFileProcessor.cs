using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Services
{
    public interface IFileProcessor
    {
        string[] ReadFromFile(string filePath);
    }
}
