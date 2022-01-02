using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.MarsRover.Direction;
using ProblemSolving.MarsRover.Helper;
using ProblemSolving.MarsRover.Models;
using Xunit;

namespace ProblemSolving.MarsRover.Tests.Rover
{
    public class RoverTest
    {
        [Fact]
        public void WhenRoverTurnRight_ThenDirectionIsEast()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new NorthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.TurnRight();

            //Assert
            Assert.Equal(MarsRover.Direction.Direction.E, rover.Direction.Direction);
        }

        [Fact]
        public void WhenRoverTurnLeft_ThenDirectionIsWest()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new NorthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.TurnLeft();

            //Assert
            Assert.Equal(MarsRover.Direction.Direction.W, rover.Direction.Direction);
        }

        [Fact]
        public void WhenRoverMove_ThenCoordinateYIncrease()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new NorthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            rover.Move();

            //Assert
            Assert.Equal(++coordinate.CoordinateY, rover.Coordinate.CoordinateY);
        }

        [Fact]
        public void WhenCall_ThenPrintCurrentLocation()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            IDirection direction = new NorthDirection();
            MarsRover.Rover.Rover rover = new MarsRover.Rover.Rover(plateau, coordinate, direction);

            //Act
            string actual = rover.CurrentLocation();

            //Assert
            Assert.Equal("1 2 N", actual);
        }

        [Theory]
        [InlineData("1 2 N", "LMLMLMLMM", "1 3 N")]
        [InlineData("3 3 E", "MMRMMRMRRM", "5 1 E")]
        public void WhenCallExecuteCommandList_ThenPrintCorrectResult(string roverLine, string commandLine, string expectedLocation)
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            MarsRover.Rover.Rover rover = InputHelper.ParsePositionInput(roverLine, plateau);
            List<MarsRover.Command.ICommand> commands = InputHelper.ParseCommandInput(commandLine);
            //Act
            rover.ExecuteCommandList(commands);

            //Assert
            Assert.Equal(expectedLocation, rover.CurrentLocation());
        }
    }
}
