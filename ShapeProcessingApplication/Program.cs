using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ShapeProcessingApplication.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShapeProcessingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shape Procesing Application");

            //For depenency Injection
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IFileProcessor, TextFileProcessor>()
            .AddSingleton<IShapeFactory, ShapeFactory>()
            .AddSingleton<IShapeProcessor, ShapeProcessor>()
            .AddSingleton<IOutput, ConsoleOutput>()
            .BuildServiceProvider();

            IShapeService shapeService = new ShapeService(serviceProvider.GetService<IFileProcessor>(), 
                serviceProvider.GetService<IShapeFactory>(), 
                serviceProvider.GetService<IShapeProcessor>(), 
                serviceProvider.GetService<IOutput>());

            string input;
            do
            {
                Console.Write("Please enter file Path: ");
                string filePath;
                filePath = Console.ReadLine();
                if (shapeService.IsPathExists(filePath))
                {
                    var lines = shapeService.ReadFile(filePath);
                    if(!shapeService.ProcessFile(lines))
                        Console.WriteLine("No valid Shape type found in input file");
                    shapeService.Write();
                }
                else
                    Console.WriteLine("Invalid file path");

                Console.Write("Do you want to continue?(Y): ");
                input = Console.ReadLine();

            } while (input.ToUpper().Equals("Y"));
            
        }
    }
}
