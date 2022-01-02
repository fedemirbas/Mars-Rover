using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Models
{
    public class Coordinate : ICoordinate
    {
        private int _CoordinateX;
        private int _CoordinateY;

        public Coordinate(int CoordinateX, int CoordinateY)
        {
            _CoordinateX = CoordinateX;
            _CoordinateY = CoordinateY;
        }

        public int CoordinateX { get { return _CoordinateX; } set { _CoordinateX = value; } }

        public int CoordinateY { get { return _CoordinateY; } set { _CoordinateY = value; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_CoordinateX);
            sb.Append(" ");
            sb.Append(_CoordinateY);

            return sb.ToString();
        }
    }
}
