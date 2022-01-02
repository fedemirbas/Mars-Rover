using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.MarsRover.Direction
{
    public class NorthDirection : IDirection
    {
        public Direction Direction { get { return _direction; } set { _direction = value; } }

        private Direction _direction;

        public NorthDirection()
        {
            _direction = Direction.N;
        }

        public IDirection TurnRight()
        {
            return new EastDirection();
        }

        public IDirection TurnLeft()
        {
            return new WestDirection();
        }

        public void Move(Rover.Rover rover)
        {
            rover.Coordinate.CoordinateY += 1;
        }
    }
}
