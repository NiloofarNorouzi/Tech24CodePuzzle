using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech24CodePuzzle.Model;

namespace Tech24CodePuzzle.Business
{
    public static class ShapeProvider
    {
        public static IShape CreateShape(string shapeType, Dictionary<string, double> dimensions)
        {
            return shapeType.ToLower() switch
            {
                "circle" => new Circle(dimensions["radius"]),
                "rectangle" => new Rectangle(dimensions["width"], dimensions["height"]),
                "square" => new Square(dimensions["side_length"]),
                "isoscelestriangle" => new IsoscelesTriangle(dimensions["width"], dimensions["height"]),
                _ => throw new ArgumentException($"Shape '{shapeType}' is not supported.")
            };
        }

        public static Dictionary<string, List<string>> GetAllSupportedShape()
        {
            var allShapes = new Dictionary<string, List<string>>
            {
                    { "circle",new List<string>{ "radius"} },
                    { "rectangle",new List<string>{ "width" , "height" } },
                    { "square",new List<string>{ "side_length" } },
                    { "isoscelestriangle",new List<string>{ "width" , "height" } },
            };
            return allShapes;
        }
    }
}
