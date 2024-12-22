using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech24CodePuzzle.Model
{
    public class Circle : IShape
    {
        public string Name => "Circle";
        public Dictionary<string, double> Dimensions { get; }

        public Circle(double radius)
        {
            Dimensions = new Dictionary<string, double> { { "Radius", radius } };
        }

    }
}
