using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProcessingApplication.Services
{
    public static class Helper
    {
        //Valid expected Argument for each Shape
        public static Dictionary<Shape, int> ShapeArgumentSettings {
            get
            {
                return new Dictionary<Shape, int>()
                {
                    {Shape.Circle, 1 },
                    {Shape.Square, 1 },
                    {Shape.Rectangle, 2 },
                    {Shape.Triangle, 2 }
                };
            }
        }
    }
}
