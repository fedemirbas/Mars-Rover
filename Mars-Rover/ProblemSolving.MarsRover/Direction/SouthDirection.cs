using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Direction
{
    public class SouthDirection : IDirection
    {
        public Direction Direction { get { return _direction; } set { _direction = value; } }

        private Direction _direction;

        public SouthDirection()
        {
            _direction = Direction.S;
        }

        public IDirection TurnRight()
        {
            return new WestDirection();
        }

        public IDirection TurnLeft()
        {
            return new EastDirection();
        }

        public void Move(Rover.Rover rover)
        {
            rover.Coordinate.CoordinateY -= 1;
        }
    }
}
