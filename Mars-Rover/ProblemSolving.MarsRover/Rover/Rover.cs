using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.MarsRover.Command;
using ProblemSolving.MarsRover.Direction;
using ProblemSolving.MarsRover.Helper;
using ProblemSolving.MarsRover.Models;

namespace ProblemSolving.MarsRover.Rover
{
    public class Rover
    {
        private Plateau _plateau;
        private Coordinate _coordinate;
        private IDirection _direction;

        public Rover(Plateau plateau, Coordinate coordinate, IDirection direction)
        {
            if (plateau == null) throw new NullReferenceException(ExceptionMessages.PlateauIsNull);
            if (direction == null) throw new NullReferenceException(ExceptionMessages.DirectionIsNull);

            _plateau = plateau;
            _coordinate = coordinate;
            _direction = direction;
            CheckLocation();
        }

        public Coordinate Coordinate { get { return _coordinate; } set { _coordinate = value; } }
        public IDirection Direction { get { return _direction; } set { _direction = value; } }

        public void TurnRight()
        {
            _direction = _direction.TurnRight();
        }

        public void TurnLeft()
        {
            _direction = _direction.TurnLeft();
        }

        public void Move()
        {
            _direction.Move(this);
            CheckLocation();
        }

        private void CheckLocation()
        {
            if (_coordinate.CoordinateX > _plateau.TopRightCoordinate.CoordinateX
                || _coordinate.CoordinateY > _plateau.TopRightCoordinate.CoordinateY
                || _coordinate.CoordinateX < _plateau.BottomLeftCoordinate.CoordinateX
                || _coordinate.CoordinateY < _plateau.BottomLeftCoordinate.CoordinateY)
                throw new RoverOutOfBoundsException();
        }

        public void ExecuteCommandList(List<ICommand> commandList)
        {
            foreach (var command in commandList)
            {
                command.Execute(this);
            }
        }

        public string CurrentLocation()
        {
            return _coordinate.ToString() + " " + _direction.Direction.ToString();
        }
    }
}
