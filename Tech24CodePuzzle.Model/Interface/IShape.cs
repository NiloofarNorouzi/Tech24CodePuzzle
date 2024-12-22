using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech24CodePuzzle.Model
{
    public interface IShape
    {
        string Name { get; }
        Dictionary<string, double> Dimensions { get; }
    }
}
