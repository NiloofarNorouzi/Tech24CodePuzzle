using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech24CodePuzzle.Model
{
    public class Square : IShape
    {
        public string Name => "Square";
        public Dictionary<string, double> Dimensions { get; }

        public Square(double sidelength)
        {
            Dimensions = new Dictionary<string, double> { { "SideLenght", sidelength } };
        }
    }
}