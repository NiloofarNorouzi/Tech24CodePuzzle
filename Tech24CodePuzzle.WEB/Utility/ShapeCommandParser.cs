using System.Text.RegularExpressions;
using Tech24CodePuzzle.Business;
using Tech24CodePuzzle.Model;

namespace Tech24CodePuzzle.WEB
{
    public class ShapeCommandParser
    {
        public IShape ParseInput(string command)
        {
            IShape shape;
            var supportedShapes = ShapeProvider.GetAllSupportedShape();
            string shapeType;

            Dictionary<string, double> Dimensions = new Dictionary<string, double>();

            var regex = new Regex(@"Draw (a|an) (.+?) with a (.+?) of (\d+)(?: and a (.+?) of (\d+))?", RegexOptions.IgnoreCase);
            var match = regex.Match(command);

            if (match.Success)
            {
                shapeType = match.Groups[2].Value.ToLower();

                if (!supportedShapes.ContainsKey(shapeType))
                {
                    throw new Exception("Invalid or unsupported shape is provided");
                }

                var requiredShapeProperies = supportedShapes[shapeType];

                for (int i = 1; i <= requiredShapeProperies.Count; i++)
                {
                    var index =1+( i * 2);
                    var propertyName = match.Groups[index].Value.Replace(" ", "_");

                    if (match.Groups[index].Success && match.Groups[index + 1].Success && requiredShapeProperies.Contains(propertyName))
                    {
                        double propertyValue;
                        if (double.TryParse(match.Groups[index + 1].Value, out propertyValue))
                            Dimensions[propertyName] = propertyValue;
                        else
                            throw new Exception($"Invalid value for the property ' {match.Groups[index].Value}' = '{match.Groups[index + 1].Value}'");
                    }
                    else
                    {
                        throw new Exception("Invalid required property for the shape.");
                    }
                }

            }
            else
                throw new Exception("Invalid input!");

            shape = ShapeProvider.CreateShape(shapeType, Dimensions);

            return shape;
        }
    }
}
