using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Services
{
    class TextFileProcessor : IFileProcessor
    {
        public string[] ReadFromFile(string filePath)
        {
            try
            {
                return File.ReadAllLines(filePath);
            }
            catch
            {
                Console.WriteLine("Enable to read the file");
                return null;
            }
            
        }
    }
}
