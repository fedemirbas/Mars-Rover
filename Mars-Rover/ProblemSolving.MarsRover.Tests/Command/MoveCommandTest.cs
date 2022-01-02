using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.MarsRover.Command;
using ProblemSolving.MarsRover.Direction;
using ProblemSolving.MarsRover.Models;
using Xunit;

namespace ProblemSolving.MarsRover.Tests.Command
{
    public class MoveCommandTest
    {
        [Fact]
        public void WhenCommandIsTurnRight_ThenRoverTurnRight()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new NorthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);
            ICommand command = new MoveCommand();

            //Act
            command.Execute(rover);

            //Assert
            Assert.Equal(++coordinate.CoordinateY, rover.Coordinate.CoordinateY);
        }
    }
}
