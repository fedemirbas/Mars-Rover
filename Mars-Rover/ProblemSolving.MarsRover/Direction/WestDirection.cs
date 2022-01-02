using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Direction
{
    public class WestDirection : IDirection
    {
        public Direction Direction { get { return _direction; } set { _direction = value; } }

        private Direction _direction;

        public WestDirection()
        {
            _direction = Direction.W;
        }

        public IDirection TurnRight()
        {
            return new NorthDirection();
        }

        public IDirection TurnLeft()
        {
            return new SouthDirection();
        }

        public void Move(Rover.Rover rover)
        {
            rover.Coordinate.CoordinateX -= 1;
        }
    }
}
