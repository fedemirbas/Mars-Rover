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
    public class TurnLeftCommandTest
    {
        [Fact]
        public void WhenCommandIsTurnLeft_ThenRoverTurnLeft()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new NorthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);
            ICommand command = new TurnLeftCommand();

            //Act
            command.Execute(rover);

            //Assert
            Assert.Equal(MarsRover.Direction.Direction.W, rover.Direction.Direction);
        }
    }
}
