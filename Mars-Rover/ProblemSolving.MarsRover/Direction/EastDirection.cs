using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Direction
{
    public class EastDirection : IDirection
    {
        public Direction Direction { get { return _direction; } set { _direction = value; } }

        private Direction _direction;

        public EastDirection()
        {
            _direction = Direction.E;
        }

        public IDirection TurnRight()
        {
            return new SouthDirection();
        }

        public IDirection TurnLeft()
        {
            return new NorthDirection();
        }

        public void Move(Rover.Rover rover)
        {
            rover.Coordinate.CoordinateX += 1;
        }
    }
}
