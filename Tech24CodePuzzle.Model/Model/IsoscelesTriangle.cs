using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech24CodePuzzle.Model
{
    public class IsoscelesTriangle : IShape
    {
        public string Name => "Isosceles Triangle";
        public Dictionary<string, double> Dimensions { get; }

        public IsoscelesTriangle(double width, double height)
        {
            Dimensions = new Dictionary<string, double> { { "Width", width }, { "Height", height } };
        }
    }
}