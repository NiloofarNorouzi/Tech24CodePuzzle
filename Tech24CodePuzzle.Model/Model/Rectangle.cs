using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech24CodePuzzle.Model
{
    public class Rectangle : IShape
    {
        public string Name => "Rectangle";
        public Dictionary<string, double> Dimensions { get; }

        public Rectangle(double width, double height)
        {
            Dimensions = new Dictionary<string, double> { { "Width", width }, { "Height", height } };
        }

    }
}