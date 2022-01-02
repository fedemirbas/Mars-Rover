using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Models
{
    public class Plateau : IPlateau
    {
        private Coordinate _TopRightCoordinate;
        private Coordinate _BottomLeftCoordinate;

        public Plateau(int topRightCoordinateX, int topRightCoordinateY)
        {
            _TopRightCoordinate = new Coordinate(topRightCoordinateX, topRightCoordinateY);
            _BottomLeftCoordinate = new Coordinate(0, 0);
        }

        public Coordinate TopRightCoordinate { get { return _TopRightCoordinate; } set { _TopRightCoordinate = value; } }

        public Coordinate BottomLeftCoordinate { get { return _BottomLeftCoordinate; } set { _BottomLeftCoordinate = value; } }

    }
}
