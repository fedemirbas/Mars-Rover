using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Models
{
    public interface IPlateau
    {
        Coordinate TopRightCoordinate { get; set; }
        Coordinate BottomLeftCoordinate { get; set; }
    }
}
