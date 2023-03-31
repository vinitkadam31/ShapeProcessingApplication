using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Services
{
    public class ShapeService : IShapeService
    {
        private IFileProcessor fileProcessor;
        private IShapeFactory shapeFactory;
        private IShapeProcessor shapeProcessor;
        private IOutput output;
        
        private static string splitDelimeter = " ";
        public ShapeService(IFileProcessor fileProcessor, IShapeFactory shapeFactory, IShapeProcessor shapeProcessor, IOutput output)
        {
            this.fileProcessor = fileProcessor;
            this.shapeFactory = shapeFactory;
            this.shapeProcessor = shapeProcessor;
            this.output = output;
        }

        public bool IsPathExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public string[] ReadFile(string filePath)
        {
            return fileProcessor.ReadFromFile(filePath);
        }

        public bool ProcessFile(string[] lines)
        {
            Clear();
            if(lines != null)
            {
                foreach (var line in lines)
                    ProcessLine(line);
            }
            Sort();
            return AnyShapeProcessed();
        }

        public void Write()
        {
            output.write(shapeProcessor.getList());
        }

        private void ProcessLine(string line)
        {
            string[] splittedLine = line.Split(splitDelimeter);

            Shape shapeType;
            if (splittedLine.Length > 0 &&
                Enum.TryParse<Shape>(splittedLine.FirstOrDefault(), true, out shapeType) && // Check for Valid Shape
                ArgsLengthValidator(splittedLine.Skip(1).Count(), shapeType) && ArgsValidator(splittedLine)) // Validate shape arguments
            {
                shapeProcessor.Add(shapeFactory.Create(shapeType, splittedLine));
            }
        }

        //Template Validating with respect to Shape if parameter is greater than expected it will ignore it 
        private bool ArgsLengthValidator(int argLength, Shape ShapType)
        {
            return Helper.ShapeArgumentSettings.ContainsKey(ShapType) && Helper.ShapeArgumentSettings[ShapType] == argLength;
        }

        private bool ArgsValidator(string[] splittedLine)
        {
            double value;
            return splittedLine.Skip(1).All(x => double.TryParse(x, out value) && value > 0);
        }
        private void Sort()
        {
            shapeProcessor.Sort();
        }

        private void Clear()
        {
            shapeProcessor.Clear();
        }

        private bool AnyShapeProcessed()
        {
            return shapeProcessor.getList().Count() != 0;
        }
    }
}
